using System;
using System.Diagnostics;

class Checker
{
    public static string isBPMok(float bpm)
    {
        string warning = "current bpm: "+bpm+ ",bpm normal";
        if(bpm < 70)
        {
            warning = "current bpm: "+bpm+ ",bpm too low";
        }
        else if(bpm > 150)
        {
            warning = "current bpm: "+bpm+ ",bpm too high";
        }
        return warning;
    }

    public static string isSPO2ok(float spo2)
    {
        string warning = "current spo2: "+spo2+ ",spo2 normal";
        if(spo2 < 90)
        {
            warning = "current spo2: "+spo2+ ",spo2 too low";
        }
        else if(spo2 > 100)
        {
            warning = "current spo2: "+spo2+ ",spo2 too high";
        }
        return warning;
    }

    public static string isRespRateok(float respRate)
    {
        string warning = "current respRate: "+respRate+ ",respRate normal";
        if(respRate < 30)
        {
            warning = "current respRate: "+respRate+ ",respRate too low";
        }
        else if(respRate > 95)
        {
            warning = "current respRate: "+respRate+ ",respRate too high";
        }
        return warning;
    }    

    static void areVitalsOk(float bpm, float spo2, float respRate)
    {
        Console.WriteLine(isBPMok(bpm));
        Console.WriteLine(isSPO2ok(spo2));
        Console.WriteLine(isRespRateok(respRate));
    }

    // static void ExpectTrue(bool expression) {
    //     if(!expression) {
    //         Console.WriteLine("Expected true, but got false");
    //         Environment.Exit(1);
    //     }
    // }
    // static void ExpectFalse(bool expression) {
    //     if(expression) {
    //         Console.WriteLine("Expected false, but got true");
    //         Environment.Exit(1);
    //     }
    // }
    static int Main() {
        // ExpectTrue(vitalsAreOk(100, 95, 60));
        // ExpectFalse(vitalsAreOk(40, 91, 92));
        // Console.WriteLine(isBPMok(180));
        // Console.WriteLine(isSPO2ok(23));
        // Console.WriteLine("All ok");
        areVitalsOk(100, 95,  60);
        areVitalsOk(120, 98,  29);
        areVitalsOk(80,  89,  85);
        areVitalsOk(95,  101, 96);
        areVitalsOk(65,  94,  35);
        areVitalsOk(165, 93,  27);
        areVitalsOk(69,  102, 45);
        areVitalsOk(169, 88,  98);
        return 0;
    }
}
