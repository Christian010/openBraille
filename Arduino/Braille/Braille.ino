#include <AccelStepper.h>

#define BRAILLEMAX 3
#define MINSTEPS 512
#define BACKWARDMOVE false
#define FORWARDMOVE true

AccelStepper stepperA1(AccelStepper::HALF4WIRE, 3, 5, 4, 6);
AccelStepper stepperB1(AccelStepper::HALF4WIRE, 7, 9, 8, 10);

AccelStepper stepperA2(AccelStepper::HALF4WIRE, 26, 28, 27, 29);
AccelStepper stepperB2(AccelStepper::HALF4WIRE, 30, 32, 31, 33);

AccelStepper stepperA3(AccelStepper::HALF4WIRE, 34, 36, 35, 37);
AccelStepper stepperB3(AccelStepper::HALF4WIRE, 38, 40, 39, 41);


AccelStepper motorListA[BRAILLEMAX] = {stepperA1, stepperA2, stepperA3};
AccelStepper motorListB[BRAILLEMAX] = {stepperB1, stepperB2, stepperB3};

                                //a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z
const byte lettersPositionsA[] = {1, 3, 1, 1, 1, 3, 3, 3, 2, 1, 5, 7, 5, 5, 5, 7, 7, 7, 6, 6, 5, 7, 2, 5, 5, 5};
const byte lettersPositionsB[] = {0, 0, 1, 3, 2, 1, 3, 2, 1, 3, 0, 0, 1, 3, 2, 1, 3, 2, 1, 3, 4, 4, 7, 5, 7, 6};

byte positionsA[BRAILLEMAX] = {0, 0, 0};
byte positionsB[BRAILLEMAX] = {0, 0, 0};

bool motorDirListA[BRAILLEMAX] = {FORWARDMOVE, FORWARDMOVE, FORWARDMOVE};
bool motorDirListB[BRAILLEMAX] = {FORWARDMOVE, FORWARDMOVE, FORWARDMOVE};

void setup() {
  Serial.begin(9600);
  for (int i = 0; i < BRAILLEMAX; i++) {
      motorListA[i].setMaxSpeed(1000.0);
      motorListA[i].setAcceleration(100.0);
      motorListA[i].setSpeed(500.0);
      motorListB[i].setMaxSpeed(1000.0);
      motorListB[i].setAcceleration(100.0);
      motorListB[i].setSpeed(500.0);
  }
}

void loop() {
  String text;
  byte stepsA;
  byte stepsB;
  bool moving;
  while (!Serial.available())
  {
    delay(100);
  }
  text = Serial.readStringUntil('\n');
  if (text[0] == '#') {
    switch (text[1]) {
      case 'f':
        if (text[2] == 'a') {
          Serial.print("Moving motor A:");
          Serial.print(text[3]);
          Serial.println(" forward");
          motorListA[text[3] - '0'].move(MINSTEPS);
        }
        else if (text[2] == 'b') {
          Serial.print("Moving motor B:");
          Serial.print(text[3]);
          Serial.println(" forward");
          motorListB[text[3] - '0'].move(-MINSTEPS);
        }
        break;
      case 'b':
        if (text[2] == 'a') {
          Serial.print("Moving motor A:");
          Serial.print(text[3]);
          Serial.println(" backward");
          motorListA[text[3] - '0'].move(-MINSTEPS);
        }
        else if (text[2] == 'b') {
          Serial.print("Moving motor B:");
          Serial.print(text[3]);
          Serial.println(" backward");
          motorListB[text[3] - '0'].move(MINSTEPS);
        }
        break;
    }
  }
  else {
    for (int i = 0; i < BRAILLEMAX; i++) {
      if (i < text.length() && text[i] != 32) {
        if (text[i] >= 97 && text[i] <= 122) { //Minusculas en ASCII
          if (positionsA[i] > lettersPositionsA[text[i] - 97]) {
            motorDirListA[i] = FORWARDMOVE;
          }
          else if (positionsA[i] < lettersPositionsA[text[i] - 97]) {
            motorDirListA[i] = BACKWARDMOVE;
          }
          if (positionsB[i] > lettersPositionsB[text[i] - 97]) {
            motorDirListB[i] = FORWARDMOVE;
          }
          else if (positionsB[i] < lettersPositionsB[text[i] - 97]) {
            motorDirListB[i] = BACKWARDMOVE;
          }
          stepsA = abs(positionsA[i] - lettersPositionsA[text[i] - 97]);
          stepsB = abs(positionsB[i] - lettersPositionsB[text[i] - 97]);
          positionsA[i] = lettersPositionsA[text[i] - 97];
          positionsB[i] = lettersPositionsB[text[i] - 97];
        }
      }
      else {
        if (positionsA[i] != 0) {
            motorDirListA[i] = FORWARDMOVE;
        }
        if (positionsB[i] != 0) {
            motorDirListB[i] = FORWARDMOVE;
        }
        stepsA = positionsA[i];
        stepsB = positionsB[i];
        positionsA[i] = 0;
        positionsB[i] = 0;
      }
      if (motorDirListA[i] == FORWARDMOVE) {
        Serial.print("Moving motor A:");
        Serial.print(i);
        Serial.print(" in:");
        Serial.print(stepsA);
        Serial.println(" steps forward");
        motorListA[i].move(stepsA * MINSTEPS);
      }
      else {
        Serial.print("Moving motor A:");
        Serial.print(i);
        Serial.print(" in:");
        Serial.print(stepsA);
        Serial.println(" steps backward");
        motorListA[i].move(stepsA * -MINSTEPS);
      }
      if (motorDirListB[i] == FORWARDMOVE) {
        Serial.print("Moving motor B:");
        Serial.print(i);
        Serial.print(" in:");
        Serial.print(stepsB);
        Serial.println(" steps forward");
        motorListB[i].move(stepsB * -MINSTEPS);
      }
      else {
        Serial.print("Moving motor B:");
        Serial.print(i);
        Serial.print(" in:");
        Serial.print(stepsB);
        Serial.println(" steps backward");
        motorListB[i].move(stepsB * MINSTEPS);
      }
    }
  }
  moving = true;
  while (moving) {
    moving = false;
    for (int i = 0; i < BRAILLEMAX; i++) {
      if (motorListA[i].distanceToGo() != 0) {
        motorListA[i].run();
        moving = true;
      }
      if (motorListB[i].distanceToGo() != 0) {
        motorListB[i].run();
        moving = true;
      }
    }
  }
}
