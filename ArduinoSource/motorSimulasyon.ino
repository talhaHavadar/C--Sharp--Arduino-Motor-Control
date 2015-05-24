int ledPinOn = 5;
int ledPinArka = 6;
int ledPinSol = 10;
int ledPinSag = 9;
int yonler[] = {ledPinOn,ledPinArka,ledPinSag,ledPinSol};
char commandPack[4];

/*
 * 0 - Ön motor
 * 1 - Arka Motor
 * 2 - Sağ Motor
 * 3 - Sol Motor
 */
 byte onMotor = 0;
 byte arkaMotor = 0;
 byte sagMotor = 0;
 byte solMotor = 0;
 byte power[] = {onMotor,arkaMotor,sagMotor,solMotor};
 int powerIsChanged = 0;
 
void setup(){

  pinMode(ledPinOn,OUTPUT);
  pinMode(ledPinArka,OUTPUT);
  pinMode(ledPinSol,OUTPUT);
  pinMode(ledPinSag,OUTPUT);
  Serial.begin(9600);
  
}

void loop(){
  if(Serial.available() > 0){
    int length = 0;
    length = Serial.readBytes(commandPack,4);
    for(int i = 0; i<length; i++){
      
      analogWrite(yonler[i],commandPack[i]);
      power[i] = commandPack[i];
      powerIsChanged = 1;
    }
  }
  
  if(powerIsChanged == 1){
    Serial.write(power,4);
    powerIsChanged = 0;
  }
  
}


