//TODO DEBUG FIXME







/*
  This code is writen by JelleWho

  Pc -> Arduino
  "+000"   = Enable auto send analog data
  "-000"   = Disable auto send analog data
  ",000"   = Send analog data once
  "&$$$" & = Set amount of min difference between Analog to resync them with the PC
       $$$ = Amount of min difference, between 000 and 999 (Default 10)
  "#$$$" # = Pin number, A=pin0 B=pin1 see https://www.arduino.cc/en/Reference/ASCIIchart (numer-64=pin)
       $$$ = Value to write to pin, between 000 and 255

  Arduino -> PC
  "EE"     = Error, please resend last data
  "#$$$" # = Analog Pin number who has changed, A=pin0 B=pin1 see https://www.arduino.cc/en/Reference/ASCIIchart (numer-64=pin)
       $$$ = Value
*/
int MinDifference = 10;                                                 //min value the analog needs to change before auto send it
const int LoopDelay = 1;                                                //Lower = Send data more often (this will let the code loop max 1000x/sec so the Arduino has some time off)
const int AnalogPins = 6;                                               //Amount of analog pins to send pack to the PC, Software max 33, but even the Mega doesn't have this so no worries

void setup() {                                                          //This code will runs once in startup
  Serial.begin(9600);                                                   //Opens serial port, and sets data rate to 9600 bps
}
void loop() {                                                           //This code will keep on running after start-up
  static boolean AutoAnalog = false;                                    //If we need to send analog changes to pc automaticly (if min diffrence rule is met)
  static boolean ManualAnalog = false;                                  //Flagged once to resend the analog pins manually once
  static const byte DataLength = 4;                                     //Length of data send (DO NOT CHANGE)
  static int DataRead[DataLength];                                      //The array where the recieved data is stored in
  static int OldValAnalog[AnalogPins];                                  //The array where the old Analog sensor data is stored in
  if (Serial.available() > 0) {                                         //If we have some data
    delay(4);                                                           //Wait some time to make sure we had time to recieve it all. Time = 1/(9600/8)*1000 = 0.83ms per byte
    if (Serial.available() < 5) {                                       //If not all the data is there
      Serial.println("Fail:");                                          //Print we have a failed attempt
      for (int i = 0; Serial.available() > 0 and i < 100; i++) {        //Do for all bytes AND max 100 bytes
        Serial.print("," + String(Serial.read()));                      //Print that byte (just feedback so we know what the Arduino has recieved)
      }
    } else {                                                            //https://www.arduino.cc/en/Reference/ASCIIchart
      for (int i = 0; i < DataLength; i++) {                            //Get all the data "A999" for example
        Serial.println("Good:");                                        //Print we have a good attempt
        DataRead[i] = Serial.read();                                    //Put the data into the array
        Serial.print("," + String(DataRead[i]));                        //Print the data we have correctly recieved
      }
      int Number = -1;                                                  //Set data to be in a valid format as default
      for (int i = 1; i < DataLength; i++) {                            //Loop the next peece so we will get all values
        if (DataRead[i] < 48 or DataRead[i] > 57) {                     //If the data isn't a number
          Number = -2;                                                  //Flag data to be invalid
        }
      }
      if (Number == -1) {                                               //If the data is still not flagged invalid
        int A = DataRead[1] - 48;                                       //Convert the data to be a number
        int B = DataRead[2] - 48;                                       //^^
        int C = DataRead[3] - 48;                                       //^^
        Number = A * 100 + B * 10 + C;                                  //Calculate the whole numer
      }
      if (DataRead[0] == 38) {                                          //If "&" is retrieved
        MinDifference = Number;                                         //Set the minun diffrence between analog pins resync
      } else if (DataRead[0] == 43) {                                   //If "+" is retrieved
        AutoAnalog = true;                                              //Enable auto send analog data
      } else if (DataRead[0] == 44) {                                   //If "," is retrieved, Send analog data once
        for (int i = 0; i < AnalogPins; i++) {                          //Do for all the AnalogPins
          OldValAnalog[i] = -1;                                         //Make the Potmeter value invalid, so we will resend them
        }
        ManualAnalog = true;                                            //Send analog data once
      } else if (DataRead[0] == 45) {                                   //If "-" is retrieved
        AutoAnalog = false;                                             //Disable auto send analog data
      } if (DataRead[0] >= 65) {                                        //Check if first one is a valid pin number (65 = A = pin1)
        if (Number >= 0) {                                              //If there is a valid number
          int Pin = DataRead[0] - 64;                                   //Now A=1 B=2 etc, see asci chart (This will enable 126 pins selection basicly, so the MEGA will also work with his massive 57 pins)
          analogWrite(Pin, Number);                                     //Send the number to the Pin
          Serial.println("Write to Pin " + String(Pin) + " Number " + String(Number));  //TODO DEBUG FIXME
        }
      }
    }
  } else if (AutoAnalog == false || ManualAnalog == true) { //If we need to update the Analog states
    for (int i = 0; i < AnalogPins; i++) {                              //Do for all the AnalogPins
      int ValAnalog = analogRead(0);                                    //Read and store that pin
      if (ValAnalog - OldValAnalog[i] > MinDifference || OldValAnalog[i] - ValAnalog >= MinDifference) {  //If the pin has changed more then the Minimal Diffrence since last sync
        OldValAnalog[i] = ValAnalog;                                    //Store this value in the memory as last send value
        Serial.print("[" + ConvIntToStr(i) + String(ValAnalog) + "]");  //Send the value
      }
    }
  }
  delay(LoopDelay);                                                     //Just some loop delay
}

String ConvIntToStr(int i) {                                            //Convert number to Letter, A=0 B=1... ~=32, Returns input if it can't convert it
  switch (i) {
    case 0:
      return "A";
      break;
    case 1:
      return "B";
      break;
    case 2:
      return "C";
      break;
    case 3:
      return "D";
      break;
    case 4:
      return "E";
      break;
    case 5:
      return "F";
      break;
    case 6:
      return "G";
      break;
    case 7:
      return "H";
      break;
    case 8:
      return "I";
      break;
    case 9:
      return "J";
      break;
    case 10:
      return "K";
      break;
    case 11:
      return "L";
      break;
    case 12:
      return "M";
      break;
    case 13:
      return "N";
      break;
    case 14:
      return "O";
      break;
    case 15:
      return "P";
      break;
    case 16:
      return "Q";
      break;
    case 17:
      return "R";
      break;
    case 18:
      return "S";
      break;
    case 19:
      return "T";
      break;
    case 20:
      return "U";
      break;
    case 21:
      return "V";
      break;
    case 22:
      return "W";
      break;
    case 23:
      return "X";
      break;
    case 24:
      return "Y";
      break;
    case 25:
      return "Z";
      break;
    case 26:
      return "[";
      break;
    case 27:
      return "/";
      break;
    case 28:
      return "]";
      break;
    case 29:
      return "{";
      break;
    case 30:
      return "|";
      break;
    case 31:
      return "}";
      break;
    case 32:
      return "~";
      break;
    default:
      return i;
      break;
  }
}
