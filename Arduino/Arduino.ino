/*
  This code is writen by JelleWho
*/

const int MinDifference = 10;   //min value the analog needs to change before auto send it
const int LoopDelay = 1;        //Lower = Send data more often (this will let the code loop max 1000x/sec so the Arduino has some time off)


int Poort = 0;
int Number = 0;
int TEMPNumber = 0;
int TEMPNumber2 = 0;
boolean AutoAnalog = false;
boolean ManualAnalog = false;
int ReadIncomming_1 = 0;
int ReadIncomming_2 = 0;
int ReadIncomming_3 = 0;
int ReadIncomming_4 = 0;
int ValPot0 = 0;
int ValPot1 = 0;
int ValPot2 = 0;
int ValPot3 = 0;
int ValPot4 = 0;
int ValPot5 = 0;
int OldValPot0 = 0;
int OldValPot1 = 0;
int OldValPot2 = 0;
int OldValPot3 = 0;
int OldValPot4 = 0;
int OldValPot5 = 0;

void setup() {
  Serial.begin(9600);     // opens serial port, sets data rate to 9600 bps
}
void loop() {
  if (Serial.available() > 0) {
    // Read all stuff
    delay(4);
    ReadIncomming_1 = Serial.read();
    ReadIncomming_2 = Serial.read();
    ReadIncomming_3 = Serial.read();
    ReadIncomming_4 = Serial.read();
    //==================================================
    //https://www.arduino.cc/en/Reference/ASCIIchart
    if (ReadIncomming_2 == 44) {    //if "," is retrieved, send analog data once
      ManualAnalog = true;
    }
    if (ReadIncomming_1 == 43) {           // if "+" is retrieved, enable auto send analog
      AutoAnalog = true;
    } else if (ReadIncomming_1 == 45) {    // if "-" is retrieved, disable auto send analog
      AutoAnalog = false;
    }
    Number = 0;
    Poort = -1;
    TEMPNumber2 = ReadIncomming_1;
    if (TEMPNumber2 == 64) {
      OldValPot0 = -10;
      OldValPot1 = -10;
      OldValPot2 = -10;
      OldValPot3 = -10;
      OldValPot4 = -10;
      OldValPot5 = -10;
    }
    if (TEMPNumber2 == 65) {
      Poort = 0;
    }
    else if (TEMPNumber2 == 66) {
      Poort = 1;
    }
    else if (TEMPNumber2 == 67) {
      Poort = 2;
    }
    else if (TEMPNumber2 == 68) {
      Poort = 3;
    }
    else if (TEMPNumber2 == 69) {
      Poort = 4;
    }
    else if (TEMPNumber2 == 70) {
      Poort = 5;
    }
    else if (TEMPNumber2 == 71) {
      Poort = 6;
    }
    else if (TEMPNumber2 == 72) {
      Poort = 7;
    }
    else if (TEMPNumber2 == 73) {
      Poort = 8;
    }
    else if (TEMPNumber2 == 74) {
      Poort = 9;
    }
    else if (TEMPNumber2 == 75) {
      Poort = 10;
    }
    else if (TEMPNumber2 == 76) {
      Poort = 11;
    }
    else if (TEMPNumber2 == 77) {
      Poort = 12;
    }
    else if (TEMPNumber2 == 78) {
      Poort = 13;
    }
    //==================================================
    TEMPNumber2 = ReadIncomming_2;
    if (TEMPNumber2 == 48) {
      TEMPNumber = 0;
    }
    else if (TEMPNumber2 == 49) {
      TEMPNumber = 1;
    }
    else if (TEMPNumber2 == 50) {
      TEMPNumber = 2;
    }
    else if (TEMPNumber2 == 51) {
      TEMPNumber = 3;
    }
    else if (TEMPNumber2 == 52) {
      TEMPNumber = 4;
    }
    else if (TEMPNumber2 == 53) {
      TEMPNumber = 5;
    }
    else if (TEMPNumber2 == 54) {
      TEMPNumber = 6;
    }
    else if (TEMPNumber2 == 55) {
      TEMPNumber = 7;
    }
    else if (TEMPNumber2 == 56) {
      TEMPNumber = 8;
    }
    else if (TEMPNumber2 == 57) {
      TEMPNumber = 9;
    }
    TEMPNumber = TEMPNumber * 100;
    Number = Number + TEMPNumber;
    TEMPNumber = 0;
    //==================================================
    TEMPNumber2 = ReadIncomming_3;
    if (TEMPNumber2 == 48) {
      TEMPNumber = 0;
    }
    else if (TEMPNumber2 == 49) {
      TEMPNumber = 1;
    }
    else if (TEMPNumber2 == 50) {
      TEMPNumber = 2;
    }
    else if (TEMPNumber2 == 51) {
      TEMPNumber = 3;
    }
    else if (TEMPNumber2 == 52) {
      TEMPNumber = 4;
    }
    else if (TEMPNumber2 == 53) {
      TEMPNumber = 5;
    }
    else if (TEMPNumber2 == 54) {
      TEMPNumber = 6;
    }
    else if (TEMPNumber2 == 55) {
      TEMPNumber = 7;
    }
    else if (TEMPNumber2 == 56) {
      TEMPNumber = 8;
    }
    else if (TEMPNumber2 == 57) {
      TEMPNumber = 9;
    }
    TEMPNumber = TEMPNumber * 10;
    Number = Number + TEMPNumber;
    TEMPNumber = 0;
    //==================================================
    TEMPNumber2 = ReadIncomming_4;
    if (TEMPNumber2 == 48) {
      TEMPNumber = 0;
    }
    else if (TEMPNumber2 == 49) {
      TEMPNumber = 1;
    }
    else if (TEMPNumber2 == 50) {
      TEMPNumber = 2;
    }
    else if (TEMPNumber2 == 51) {
      TEMPNumber = 3;
    }
    else if (TEMPNumber2 == 52) {
      TEMPNumber = 4;
    }
    else if (TEMPNumber2 == 53) {
      TEMPNumber = 5;
    }
    else if (TEMPNumber2 == 54) {
      TEMPNumber = 6;
    }
    else if (TEMPNumber2 == 55) {
      TEMPNumber = 7;
    }
    else if (TEMPNumber2 == 56) {
      TEMPNumber = 8;
    }
    else if (TEMPNumber2 == 57) {
      TEMPNumber = 9;
    }
    TEMPNumber = TEMPNumber;
    Number = Number + TEMPNumber;
    TEMPNumber = 0;
    //==================================================
    analogWrite(Poort, Number);
  } else if (AutoAnalog == false || ManualAnalog == true) {
    if (ManualAnalog == true) {
      ManualAnalog = false;
      OldValPot0 = -1000;
      OldValPot1 = -1000;
      OldValPot2 = -1000;
      OldValPot3 = -1000;
      OldValPot4 = -1000;
      OldValPot5 = -1000;
    }
    ValPot0 = analogRead(0);
    if (ValPot0 - OldValPot0 > MinDifference || OldValPot0 - ValPot0 >= MinDifference) {
      OldValPot0 = ValPot0;
      Serial.print("[A" + String(ValPot0) + "]");
    }
    ValPot1 = analogRead(1);
    if (ValPot1 - OldValPot1 > MinDifference || OldValPot1 - ValPot1 >= MinDifference) {
      OldValPot1 = ValPot1;
      //Serial.print("[B" + String(ValPot1) + "]");
    }
    ValPot2 = analogRead(2);
    if (ValPot2 - OldValPot2 > MinDifference || OldValPot2 - ValPot2 >= MinDifference) {
      OldValPot2 = ValPot2;
      //Serial.print("[C" + String(ValPot2) + "]");
    }
    ValPot3 = analogRead(3);
    if (ValPot3 - OldValPot3 > MinDifference || OldValPot3 - ValPot3 >= MinDifference) {
      OldValPot3 = ValPot3;
      //Serial.print("[D" + String(ValPot3) + "]");
    }
    ValPot4 = analogRead(4);
    if (ValPot4 - OldValPot4 > MinDifference || OldValPot4 - ValPot4 >= MinDifference) {
      OldValPot4 = ValPot4;
      //Serial.print("[E" + String(ValPot4) + "]");
    }
    ValPot5 = analogRead(2);
    if (ValPot5 - OldValPot5 > MinDifference || OldValPot5 - ValPot5 >= MinDifference) {
      OldValPot5 = ValPot5;
      //Serial.print("[F" + String(ValPot5) + "]");
    }
    delay(LoopDelay);
  }
}

