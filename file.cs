
using System;
class HelloWorld {
  static void Main() {
    int count = 0;
    int fir=0;
    int sec=0;
    int thir=0;
    for (int i = 100; i<999;i++){
        fir=i/100;
        sec=((i / 10) % 10);
        thir=i%10;
        if ((Math.Abs(fir-sec)>=3) && (Math.Abs(fir-thir)>=3) && (Math.Abs(sec-thir)>=3) ){
            count++;
            //Console.WriteLine(i);
        }
    }
    Console.WriteLine(count);
  }
}
