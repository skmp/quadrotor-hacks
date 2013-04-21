// Controlling a servo position using a potentiometer (variable resistor) 
// by Michal Rinott <http://people.interaction-ivrea.it/m.rinott> 

#include <Servo.h> 
 
Servo x0, y0, x1, y1;  // create servo object to control a servo 
 
 
void setup() 
{ 
  x0.attach(9);
  y0.attach(10);
  x1.attach(11);
  y1.attach(12);
  
  Serial.begin(9600); 
}

int scale(int v)
{
  int rv = v & 0x3f;
  
  //0 ... 127 -> 992 to 2008
  return 1000 + rv*16 - 6;
}

void loop() 
{ 
  if (Serial.available() >= 1)
  {
    int data = Serial.read();
    int ds = scale(data);    
    int prt = data >> 6;
    
    if (prt == 0 ) x0.writeMicroseconds ( ds );
    if (prt == 1 ) y0.writeMicroseconds ( ds );
    if (prt == 2 ) x1.writeMicroseconds ( ds );
    if (prt == 3 ) y1.writeMicroseconds ( ds );
      
      /*
      Serial.print(dx0);
      Serial.print(" ");
      Serial.print(dy0);
      Serial.print(" ");
      Serial.print(dx1);
      Serial.print(" ");
      Serial.println(dy1);
      */
  }
} 
