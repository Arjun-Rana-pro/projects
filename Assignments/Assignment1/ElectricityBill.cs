using System.Formats.Asn1;

class EB{
        //double unit;
        double Rs;
         public void ElectricityBill(double unit){
          //this.unit=unit;
          //  if(this.unit<=20)
          //      Rs=100;
            
          //  else if(this.unit>20 && this.unit<=25)
          //       Rs = 5*this.unit;

           // else if(this.unit>25 && this.unit<=50)
             //    Rs = 10*this.unit;
                 
          //  else
           //     Rs=2000;

              //      Console.WriteLine("the total bill is: "+Rs);

              switch (unit){
                case <=20:
                Rs =100;
                break;

                case >20 and <=25:
                Rs =5*unit;
                break;

                case >25 and <=50:
                Rs =10*unit;
                break;

                default :
                Rs = 2000;
                break;

              }
              Console.WriteLine("Total bill is : "+Rs);
        }
    

    }
