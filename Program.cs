using System;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Program
    {
        /// <summary>
        /// Соломатин Ярослав П23-2.2
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №2");
            Console.WriteLine("1-30");
            int sw = Convert.ToInt32(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    double G, e1, y1, f1;

                    Console.WriteLine("Введите значение e");
                    e1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("ВВедите значение y");
                    y1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("ВВедите значение f");
                    f1= Convert.ToDouble(Console.ReadLine());

                    //G = Math.Pow(_e1, 2 * y1) + Math.Sin(f1)) / (Math.Log(3.8 * y1 + f1);
                    //Console.WriteLine($"G: {G}");
                    MyTaskClass1 myTaskClass1 = new MyTaskClass1(e1, y1, f1);
                    myTaskClass1.G1();
                    break;
                   
                case 2:
                    double F, d2, y2;

                    Console.WriteLine("Введите значение d");
                    d2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y2 = Convert.ToDouble(Console.ReadLine());

                    //F = Math.Log(_d2) + (3.5*Math.Pow(_d2, 2)+1) / (Math.Cos(2 * _y2));
                    //Console.WriteLine($"F: {F}");
                    MyTaskClass2 myTaskClass2 = new MyTaskClass2(d2, y2);
                    myTaskClass2.F2();
                    break;
                    
                case 3:
                    double U3, k3, y3;

                    Console.WriteLine("Введите значение k");
                    k3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y3 = Convert.ToDouble(Console.ReadLine());

                    //U3 = Math.Log(_k3 - _y3) + Math.Pow(_y3, 4)) / (Math.Pow(Math.E, _y3) + 2.355 * Math.Pow(_k3, 2);
                    //Console.WriteLine($"U: {U}");
                    MyTaskClass3 myTaskClass3 = new MyTaskClass3(k3, y3);
                    myTaskClass3.U3(); 
                    break;
                   
                case 4:
                    double G4, w4, y4;

                    Console.WriteLine("Введите значение - w");
                    w4 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - y");
                    y4 = Convert.ToDouble(Console.ReadLine());

                    //G = (9.33 * Math.Pow(w4, 2) + Math.Sqrt(w4)) / (Math.Log10(y4 + 3.5) + Math.Sqrt(y4));
                    //Console.WriteLine($"G: {G}");
                    MyTaskClass4 myTaskClass4 = new MyTaskClass4(w4, y4);
                    myTaskClass4.G4();
                    break;

                   
                case 5:
                    double D5, a5, t5, y5;

                    Console.WriteLine("Введите значение - a");
                    a5 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - t");
                    t5 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение  - e");
                    e5 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - y");
                    y5 = Convert.ToDouble(Console.ReadLine());

                    //D = (7.8 * Math.Pow(a5, 2) + 3.52 * t5) / (Math.Log10(a5 + 2 * y5) + Math.Pow(e5, y5));
                    //Console.WriteLine($"D: {D}");
                    MyTaskClass5 myTaskClass5 = new MyTaskClass5(a5, t5, e5, y5);
                    myTaskClass5.D();
                    break;
                   
                case 6:
                    double L, i6, y6;

                    Console.WriteLine("Введите значение - i");
                    i6 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - y");
                    y6 = Convert.ToDouble(Console.ReadLine());

                    //L = (0.81 * Math.Cos(i6)) / (Math.Log10(y6) + 2 * Math.Pow(i6, 3));
                    //Console.WriteLine($"L: {L}");
                    MyTaskClass6 myTaskClass6 = new MyTaskClass6(i6, y6);
                    myTaskClass6.L();
                    break;
                    
                case 7:
                    double N, m7, y7;

                    Console.WriteLine("Введите значение - m");
                    m7 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение- y");
                    y7 = Convert.ToDouble(Console.ReadLine());

                    //N = (Math.Pow(m7, 2) + 2.8 * m7 + 0.355) / (Math.Cos(2 * y7) + 3.6);
                    //Console.WriteLine($"N: {N}");
                    MyTaskClass7 myTaskClass7 = new MyTaskClass7(m7, y7);
                    myTaskClass7.N();
                    break;
                    
                case 8:
                    double T8, t8, y8;

                    Console.WriteLine("Введите значение - t");
                    t8 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - y");
                    y8 = Convert.ToDouble(Console.ReadLine());

                    //T = (2.37 * Math.Sin(t8 + 1)) / (Math.Sqrt(4 * Math.Pow(y8, 2) - 0.1 * y8 + 5));
                    //Console.WriteLine($"T: {T}");
                    MyTaskClass8 myTaskClass8 = new MyTaskClass8(t8, y8);
                    myTaskClass8.T();
                    break;
                    
                case 9:
                    double V, y9, w9;

                    Console.WriteLine("Введите значение - y");
                    y9 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - w");
                    w9 = Convert.ToDouble(Console.ReadLine());

                    //V = (Math.Pow(y9 + 2 * w9, 3)) / (Math.Log10(y9 + 0.75));
                    //Console.WriteLine($"V: {V}");
                    MyTaskClass9 myTaskClass9 = new MyTaskClass9(y9, w9);
                    myTaskClass9.V();
                    break;
                    
                case 10:
                    double Z, t10, y10;

                    Console.WriteLine("Введите значение - t");
                    t10 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - y");
                    y10 = Convert.ToDouble(Console.ReadLine());

                    //Z = (2 * t10 + y10 * Math.Cos(t10)) / Math.Sqrt(y10 + 4.831);
                    //Console.WriteLine($"Z: {Z}");
                    MyTaskClass10 myTaskClass10 = new MyTaskClass10(t10, y10);
                    myTaskClass10.Z();
                    break;
                   
                case 11:
                    double D11, y11, n11;

                    Console.WriteLine("Введите значение - y");
                    y11 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - n");
                    n11 = Convert.ToDouble(Console.ReadLine());

                    //D11 = (Math.Pow(y11, 2) + 0.5 * n11 + 4.8) / Math.Sin(y11);
                    //Console.WriteLine($"D2: {D2}");
                    MyTaskClass11 myTaskClass11 = new MyTaskClass11(y11, n11);
                    myTaskClass11.D11();
                    break;
                    
                case 12:
                    double R, t12, y12;

                    Console.WriteLine("Введите значение  - t");
                    t12 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение  - y");
                    y12 = Convert.ToDouble(Console.ReadLine());

                    //R = (Math.Sin(Math.Pow(2 * t12 + 1, 2)) + 0.3) / (Math.Log10(t12 + y12));
                    //Console.WriteLine($"R: {R}");
                    MyTaskClass12 myTaskClass12 = new MyTaskClass12(t12, y12);
                    myTaskClass12.R();
                    break;
                    
                case 13:
                    double A, y13, h13, e13;

                    Console.WriteLine("Введите значение  - y");
                    y13 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение  - h");
                    h13 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение  - e");
                    e13 = Convert.ToDouble(Console.ReadLine());

                    //A = (Math.Sin(2 * y13 + h) + Math.Pow(h13, 2)) / (Math.Pow(e13, h13) + y13);
                    //Console.WriteLine($"A: {A}");
                    MyTaskClass13 myTaskClass13 = new MyTaskClass13(y13, h13, e13);
                    myTaskClass13.A();
                    break;
                   
                case 14:
                    double P, e14, y14, h14;

                    Console.WriteLine("Введите значение - e");
                    e14 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - y");
                    y14 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - h");
                    h14 = Convert.ToDouble(Console.ReadLine());
                    //P = (Math.Pow(e14, y14 + 2.5) + 7.1 * Math.Pow(h14, 2)) / (Math.Pow(e14, h14) + y14);
                    //Console.WriteLine($"P: {P}");
                    MyTaskClass14 myTaskClass14 = new MyTaskClass14(e14, y14, h14);
                    myTaskClass14.P();
                    break;
                    
                case 15:
                    double F, y15, j15;

                    Console.WriteLine("Введите значение - y");
                    y15 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - j");
                    j15 = Convert.ToDouble(Console.ReadLine());

                    //F = (2 * Math.Sin(0.354 * y15 + 1)) / (Math.Log10(y15 + 2 * j15));
                    //Console.WriteLine($"F: {F}");
                    MyTaskClass15 myTaskClass15 = new MyTaskClass15(y15, j15);
                    myTaskClass15.F();
                    break;
                    
                case 16:
                    double W, t16, r16, e16, y16;

                    Console.WriteLine("Введите значение - t");
                    t16 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - r");
                    r16 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение- e");
                    e16 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - y");
                    y16 = Convert.ToDouble(Console.ReadLine());

                    //W = (4 * Math.Pow(t16, 3) + Math.Log10(r16)) / (Math.Pow(e16, y16 + r16) + 7.2 * Math.Sin(r16));
                    //Console.WriteLine($"W: {W}");
                    MyTaskClass16 myTaskClass16 = new MyTaskClass16(t16, r16, e16, y16);
                    myTaskClass16.W();
                    break;
                   
                case 17:
                    double H, y17, n17;

                    Console.WriteLine("Введите значение - y");
                    y17 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - n");
                    n17 = Convert.ToDouble(Console.ReadLine());

                    //H = (Math.Pow(y17, 2) - 0.8 * y17 + Math.Sqrt(y17)) / (23.1 * Math.Pow(n17, 2) + Math.Cos(n17));
                    //Console.WriteLine($"H: {H}");
                    MyTaskClass17 myTaskClass17 = new MyTaskClass17(y17, n17);
                    myTaskClass17.H();
                    break;
                   
                case 18:
                    double R18, y18, k18;

                    Console.WriteLine("Введите значение - y");
                    y18 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение- k");
                    k18 = Convert.ToDouble(Console.ReadLine());

                    //R18 = (Math.Sqrt(Math.Pow(Math.Sin(y18), 2) + 6.835) / (Math.Log10(y18 + k18)) + 3 * Math.Pow(y18, 2));
                    //Console.WriteLine($"R3: {R3}");
                    MyTaskClass18 myTaskClass18 = new MyTaskClass18(y18, k18);
                    myTaskClass18.R18();
                    break;
                   
                case 19:
                    double E, y19, q19;

                    Console.WriteLine("Введите значение - y");
                    y19 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - q");
                    q19 = Convert.ToDouble(Console.ReadLine());

                    //E = (Math.Log10(0.7 * y19 + 2 * q19)) / (Math.Sqrt(3 * Math.Pow(y19, 2) + 0.5 * y19 + 4));
                    //Console.WriteLine($"E: {E}");
                    MyTaskClass19 myTaskClass19 = new MyTaskClass19(y19, q19);
                    myTaskClass19.E();
                    break;
                    
                case 20:
                    double K, t20, l20, y20, e20;

                    Console.WriteLine("Введите значение - t");
                    t20 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - l");
                    l20 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - y");
                    y20 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - e");
                    e20 = Convert.ToDouble(Console.ReadLine());

                    //K = (2 * Math.Pow(t20, 2) + 3 * l20 + 7.2) / (Math.Log10(y20 + Math.Pow(e20, 2 * l20)));
                    //Console.WriteLine($"K: {K}");
                    MyTaskClass20 myTaskClass20 = new MyTaskClass20(t20, l20, y20, e20);
                    myTaskClass20.K();
                    break;
                    
                case 21:
                    double Q, k21, x21, d21, p21;

                    Console.WriteLine("Введите значение - k");
                    k21 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - x");
                    x21 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - d");
                    d21 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - p");
                    p21 = Convert.ToDouble(Console.ReadLine());

                    //Q = (Math.Sqrt(k21 + 2.6 * p21 * Math.Sin(k21)) / (x21 - Math.Pow(d21, 3)));
                    //Console.WriteLine($"Q: {Q}");
                    MyTaskClass21 myTaskClass21 = new MyTaskClass21(k21, x21, d21, p21);
                    myTaskClass21.Q();
                    break;
                    
                case 22:
                    double S, y22, t22;

                    Console.WriteLine("Введите значение - y");
                    y22 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - t");
                    t22 = Convert.ToDouble(Console.ReadLine());

                    // S = (4.351 * Math.Pow(y22, 3) + 2 * t22 * Math.Log10(t22)) / (Math.Sqrt(Math.Cos(2 * y22) + 4.351));
                    //Console.WriteLine($"S: {S}");
                    MyTaskClass22 myTaskClass22 = new MyTaskClass22(y22, t22);
                    myTaskClass22.S();
                    break;
                    
                
               case 23:
                    double R23, y23, d23, e23;

                    Console.WriteLine("Введите значение - y");
                    y23 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение- d");
                    d23 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - e");
                    e23 = Convert.ToDouble(Console.ReadLine());

                    //R23 = (Math.Pow(Math.Sin(y23), 2) + 0.3 * d23) / (Math.Pow(e23, y23) + Math.Log10(d23));
                    //Console.WriteLine($"R5: {R23}");
                    MyTaskClass23 myTaskClass23 = new MyTaskClass23(y23, d23, e23);
                    myTaskClass23.R23();
                    break;
                    
                case 24:
                    double U, k21, e15, y24;

                    Console.WriteLine("Введите значение - k");
                    k24 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - e");
                    e24 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - y");
                    y24 = Convert.ToDouble(Console.ReadLine());

                    //U = (Math.Log10(2 * k24 + 4.3)) / (Math.Pow(e24, k24 + y24) + Math.Sqrt(y24));
                    //Console.WriteLine($"U: {U}");
                    MyTaskClass24 myTaskClass24 = new MyTaskClass24(k24, e24, y24);
                    myTaskClass24.U();
                    break;
                    
                case 25:
                    double L25, c25, t25;

                    Console.WriteLine("Введите значение - c");
                    c25 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение- t");
                    t25 = Convert.ToDouble(Console.ReadLine());

                    //L25 = (Math.Pow(Math.Cos(c25), 2) + (3 * Math.Pow(t25, 2) + 4)) / (Math.Sqrt(c25 + t25));
                    //Console.WriteLine($"L: {L25}");
                    MytaskClass25 myTaskClass25 = new MytaskClass25(c25, t25);
                    myTaskClass25.L25();
                    break;
                   
                case 26:
                    double T26, u26, y26;

                    Console.WriteLine("Введите значение - u");
                    u26 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - y");
                    y26 = Convert.ToDouble(Console.ReadLine());

                    //T26 = (Math.Sin(2 * u26)) / (Math.Log10(2 * y26 + u26));
                    //Console.WriteLine($"T6: {T6}");
                    MyTaskClass26 myTaskClass26 = new MyTaskClass26(u26, y26);
                    myTaskClass26.T26();
                    break;

                    
                case 27:
                    double Z27, p27, y27;

                    Console.WriteLine("Введите значение - p");
                    p27 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - y");
                    y27 = Convert.ToDouble(Console.ReadLine());

                    //Z27 = (Math.Sin(Math.Pow(p27 + 0.4, 2))) / (Math.Pow(y27, 2) + 7.325 * p27);
                    //Console.WriteLine($"Z1: {Z1}");
                    MyTaskClass27 myTaskClass27 = new MyTaskClass27(p27, y27);
                    myTaskClass27.Z27();
                    break;
                    
                case 28:
                    double W28, v28, e28, y28;

                    Console.WriteLine("Введите значение - v");
                    v28 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - e");
                    e28 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - y");
                    y28 = Convert.ToDouble(Console.ReadLine());

                    //W28 = (0.004 * v28 + Math.Pow(e28, 2 * y28)) / (Math.Pow(e28, y28 / 2));
                    //Console.WriteLine($"W: {W28}");
                    MyTaskClass28 myTaskClass28 = new MyTaskClass28(v28, e28, y28);
                    myTaskClass28.W28();
                    break;
                    
                case 29:
                    double T29, h29, e29, y29;

                    Console.WriteLine("Введите значение - h");
                    h29 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - e");
                    e29 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - y");
                    y29 = Convert.ToDouble(Console.ReadLine());

                    //T7 = (0.355 * Math.Pow(h29, 2) - 4.355) / (Math.Pow(e29, y29 + h29) + Math.Sqrt(2.7 * y29));
                    //Console.WriteLine($"T: {T29}");
                    MyTaskClass29 myTaskClass29 = new MyTaskClass29(h29, e29, y29);
                    myTaskClass29.T29();
                    break;
                    
                case 30:
                    double N30, p30, e30, y30;

                    Console.WriteLine("Введите значение - p");
                    p30 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - e");
                    e30 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение - y");
                    y30 = Convert.ToDouble(Console.ReadLine());

                    // N30 = (3 * Math.Pow(y30, 2) + Math.Sqrt(y30 + 1)) / (Math.Log10(p30 + y30) + Math.Pow(e30, p30));
                    //Console.WriteLine($"N: {N30}");
                    MyTaskClass30 myTaskClass30 = new(p30, e30, y30);
                    myTaskClass30.N30();
                    break;


























            }




        }


        } 
    }



            

