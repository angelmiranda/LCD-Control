#include <LiquidCrystal.h>

LiquidCrystal lcd(12,11,5,4,3,2);

void setup() {
  //Define defaults for LCD
  lcd.begin(16,2);
  Serial.begin(9600);      
}

void loop() {
  //Set default text 
  const int lgtMsg = 24;
  static String text2Up = "Hello my friend"; 
  static String text2Lo = "I am here"; 

  //Display the data that we have avaiable
  lcd.setCursor(0,0);
  lcd.print(text2Up); 

  lcd.setCursor(0,1);
  lcd.print(text2Lo); 

  //Process communication with PC    
  if (Serial.available())
  {     
    switch(char(Serial.read()))
    {
      case 'A':
      {
        //Identify Us
         Serial.println("ARDUINO");
         Serial.flush();   
      }
      break;
      //Read data (from LCD to PC)
      case 'R':
      {
        //Build string to be sent to the PC
        String str24chr = "";
        for (int i=0; i<lgtMsg; i++)
        {
          str24chr += " ";
        }      
        String sendMe = (text2Up + str24chr).substring(0, lgtMsg);
        sendMe += (text2Lo + str24chr).substring(0, lgtMsg);

        //Send data to PC
        Serial.println(sendMe);
        Serial.flush(); 
      }
      break;    
      //Send data to the LCD (from PC to LCD)
      case 'S':
      {
        //Read data from PC
        String revPC = Serial.readString();
        Serial.flush(); 

        //Get string value to send to the LCD
        text2Up = revPC.substring(0,lgtMsg);
        text2Lo = revPC.substring(lgtMsg,2*lgtMsg);
        
        //Clear the LCD to update it at the beggining of the loop
        ClearMe();
      }
      break; 
    }
  }
}

void ClearMe()
{
  //Clear the LCD
  lcd.clear();
}
