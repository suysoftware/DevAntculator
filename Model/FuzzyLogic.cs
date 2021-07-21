using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringTok;
using FuzzyLogicController;
using FuzzyLogicController.RuleEngine;
using FuzzyLogicController.FLC;
using FuzzyLogicController.MFs;

namespace TezAPPV2.Model
{
    class FuzzyLogic
    {
        public static List<LingVariable> InputVariables;
        public static List<LingVariable> OutputVariables;
        public static List<Rule> Rules;
        public static List<LingVariable> InputVariablesBMI;
        public static List<LingVariable> OutputVariablesBMI;
        public static List<Rule> RulesBMI;
        public static FLC FuzzyControl;
        public static Config Configuration;

        public static void Initalize()
        {
            InputVariables = new List<LingVariable>();
            OutputVariables = new List<LingVariable>();
            Rules = new List<Rule>();
            Configuration = new Config(ImpMethod.Prod, ConnMethod.Min);
            Configuration.DefuzzificationType = DefuzzifcationType.ModifiedHeight;
            FuzzyControl = new FLC(Configuration);
        }

        public static void InitalizeBMI()   /// EGER 2.BIR KIYAFET EKLENİRSE AYARLAMAYI BÖYLE YPAICAZ
        {
            InputVariablesBMI = new List<LingVariable>();
            OutputVariablesBMI = new List<LingVariable>();
            RulesBMI = new List<Rule>();
            Configuration = new Config(ImpMethod.Prod, ConnMethod.Min);
            Configuration.DefuzzificationType = DefuzzifcationType.ModifiedHeight;
            FuzzyControl = new FLC(Configuration);
        }


        public static void FuzzyChestOption()
        {


            // Inputs
            LingVariable X1 = new LingVariable("X1", VarType.Input);
            X1.setRange(654, 1490);
            X1.addMF(new Trapmf("XSmall", 400, 914, 947, 980));
            X1.addMF(new Trimf("Small", 963, 994, 1025));
            X1.addMF(new Trimf("Medium", 1016, 1050, 1084));
            X1.addMF(new Trimf("Large", 1072, 1103, 1134));
            X1.addMF(new Trimf("XLarge", 1126, 1166, 1192));
            X1.addMF(new Trapmf("XXLarge", 1184, 1228, 1240, 1700));


            LingVariable X2 = new LingVariable("X2", VarType.Input);
            X2.setRange(464, 1453);
            X2.addMF(new Trapmf("XSmall", 300, 714, 761, 808));
            X2.addMF(new Trimf("Small", 801, 835, 869));
            X2.addMF(new Trimf("Medium", 856, 872, 888));
            X2.addMF(new Trimf("Large", 882, 933, 984));
            X2.addMF(new Trimf("XLarge", 978, 1026, 1074));
            X2.addMF(new Trapmf("XXLarge", 1069, 1136, 1203, 1700));

            FuzzyLogic.InputVariables.Add(X1);
            FuzzyLogic.InputVariables.Add(X2);



            //Output
            LingVariable Y1 = new LingVariable("Y1", VarType.Output);
            Y1.setRange(40, 54);
            Y1.addMF(new Trimf("XSmall", 40, 42, 44));
            Y1.addMF(new Trimf("Small", 42, 44, 46));
            Y1.addMF(new Trimf("Medium", 44, 46, 48));
            Y1.addMF(new Trimf("Large", 46, 48, 50));
            Y1.addMF(new Trimf("XLarge", 48, 50, 52));
            Y1.addMF(new Trimf("XXLarge", 50, 52, 54));

            FuzzyLogic.OutputVariables.Add(Y1);
            //Rules
            List<RuleItem> rule1in = new List<RuleItem>();
            List<RuleItem> rule1out = new List<RuleItem>();
            List<RuleItem> rule2in = new List<RuleItem>();
            List<RuleItem> rule2out = new List<RuleItem>();
            List<RuleItem> rule3in = new List<RuleItem>();
            List<RuleItem> rule3out = new List<RuleItem>();
            List<RuleItem> rule4in = new List<RuleItem>();
            List<RuleItem> rule4out = new List<RuleItem>();
            List<RuleItem> rule5in = new List<RuleItem>();
            List<RuleItem> rule5out = new List<RuleItem>();
            List<RuleItem> rule6in = new List<RuleItem>();
            List<RuleItem> rule6out = new List<RuleItem>();
            List<RuleItem> rule7in = new List<RuleItem>();
            List<RuleItem> rule7out = new List<RuleItem>();
            List<RuleItem> rule8in = new List<RuleItem>();
            List<RuleItem> rule8out = new List<RuleItem>();
            List<RuleItem> rule9in = new List<RuleItem>();
            List<RuleItem> rule9out = new List<RuleItem>();
            List<RuleItem> rule10in = new List<RuleItem>();
            List<RuleItem> rule10out = new List<RuleItem>();
            List<RuleItem> rule11in = new List<RuleItem>();
            List<RuleItem> rule11out = new List<RuleItem>();
            List<RuleItem> rule12in = new List<RuleItem>();
            List<RuleItem> rule12out = new List<RuleItem>();
            List<RuleItem> rule13in = new List<RuleItem>();
            List<RuleItem> rule13out = new List<RuleItem>();
            List<RuleItem> rule14in = new List<RuleItem>();
            List<RuleItem> rule14out = new List<RuleItem>();
            List<RuleItem> rule15in = new List<RuleItem>();
            List<RuleItem> rule15out = new List<RuleItem>();
            List<RuleItem> rule16in = new List<RuleItem>();
            List<RuleItem> rule16out = new List<RuleItem>();
            List<RuleItem> rule17in = new List<RuleItem>();
            List<RuleItem> rule17out = new List<RuleItem>();
            List<RuleItem> rule18in = new List<RuleItem>();
            List<RuleItem> rule18out = new List<RuleItem>();
            List<RuleItem> rule19in = new List<RuleItem>();
            List<RuleItem> rule19out = new List<RuleItem>();
            List<RuleItem> rule20in = new List<RuleItem>();
            List<RuleItem> rule20out = new List<RuleItem>();
            List<RuleItem> rule21in = new List<RuleItem>();
            List<RuleItem> rule21out = new List<RuleItem>();
            List<RuleItem> rule22in = new List<RuleItem>();
            List<RuleItem> rule22out = new List<RuleItem>();
            List<RuleItem> rule23in = new List<RuleItem>();
            List<RuleItem> rule23out = new List<RuleItem>();
            List<RuleItem> rule24in = new List<RuleItem>();
            List<RuleItem> rule24out = new List<RuleItem>();
            List<RuleItem> rule25in = new List<RuleItem>();
            List<RuleItem> rule25out = new List<RuleItem>();
            List<RuleItem> rule26in = new List<RuleItem>();
            List<RuleItem> rule26out = new List<RuleItem>();
            List<RuleItem> rule27in = new List<RuleItem>();
            List<RuleItem> rule27out = new List<RuleItem>();
            List<RuleItem> rule28in = new List<RuleItem>();
            List<RuleItem> rule28out = new List<RuleItem>();
            List<RuleItem> rule29in = new List<RuleItem>();
            List<RuleItem> rule29out = new List<RuleItem>();
            List<RuleItem> rule30in = new List<RuleItem>();
            List<RuleItem> rule30out = new List<RuleItem>();
            List<RuleItem> rule31in = new List<RuleItem>();
            List<RuleItem> rule31out = new List<RuleItem>();
            List<RuleItem> rule32in = new List<RuleItem>();
            List<RuleItem> rule32out = new List<RuleItem>();
            List<RuleItem> rule33in = new List<RuleItem>();
            List<RuleItem> rule33out = new List<RuleItem>();
            List<RuleItem> rule34in = new List<RuleItem>();
            List<RuleItem> rule34out = new List<RuleItem>();
            List<RuleItem> rule35in = new List<RuleItem>();
            List<RuleItem> rule35out = new List<RuleItem>();
            List<RuleItem> rule36in = new List<RuleItem>();
            List<RuleItem> rule36out = new List<RuleItem>();



            rule1in.AddRange(new RuleItem[2] { new RuleItem("X1", "XSmall"), new RuleItem("X2", "XSmall") }); //1
            rule1out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XSmall") });

            rule2in.AddRange(new RuleItem[2] { new RuleItem("X1", "Small"), new RuleItem("X2", "XSmall") });  //2
            rule2out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Small") });

            rule3in.AddRange(new RuleItem[2] { new RuleItem("X1", "Medium"), new RuleItem("X2", "XSmall") }); //3
            rule3out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Medium") });

            rule4in.AddRange(new RuleItem[2] { new RuleItem("X1", "Large"), new RuleItem("X2", "XSmall") });  //4
            rule4out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Large") });

            rule5in.AddRange(new RuleItem[2] { new RuleItem("X1", "XLarge"), new RuleItem("X2", "XSmall") });  //5 
            rule5out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XLarge") });

            rule6in.AddRange(new RuleItem[2] { new RuleItem("X1", "XXLarge"), new RuleItem("X2", "XSmall") });  //6
            rule6out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XXLarge") });

            rule7in.AddRange(new RuleItem[2] { new RuleItem("X1", "XSmall"), new RuleItem("X2", "Small") }); //7
            rule7out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Small") });

            rule8in.AddRange(new RuleItem[2] { new RuleItem("X1", "Small"), new RuleItem("X2", "Small") });  //8
            rule8out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Small") });

            rule9in.AddRange(new RuleItem[2] { new RuleItem("X1", "Medium"), new RuleItem("X2", "Small") });  //9
            rule9out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Medium") });

            rule10in.AddRange(new RuleItem[2] { new RuleItem("X1", "Large"), new RuleItem("X2", "Small") });   //10
            rule10out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Large") });

            rule11in.AddRange(new RuleItem[2] { new RuleItem("X1", "XLarge"), new RuleItem("X2", "Small") });   //11
            rule11out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XLarge") });

            rule12in.AddRange(new RuleItem[2] { new RuleItem("X1", "XXLarge"), new RuleItem("X2", "Small") });   //12
            rule12out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XXLarge") });

            rule13in.AddRange(new RuleItem[2] { new RuleItem("X1", "XSmall"), new RuleItem("X2", "Medium") });   //13////
            rule13out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Medium") });

            rule14in.AddRange(new RuleItem[2] { new RuleItem("X1", "Small"), new RuleItem("X2", "Medium") });  //14
            rule14out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Medium") });

            rule15in.AddRange(new RuleItem[2] { new RuleItem("X1", "Medium"), new RuleItem("X2", "Medium") });  //15
            rule15out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Medium") });

            rule16in.AddRange(new RuleItem[2] { new RuleItem("X1", "Large"), new RuleItem("X2", "Medium") });  //16
            rule16out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Large") });

            rule17in.AddRange(new RuleItem[2] { new RuleItem("X1", "XLarge"), new RuleItem("X2", "Medium") }); //17
            rule17out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XLarge") });

            rule18in.AddRange(new RuleItem[2] { new RuleItem("X1", "XXLarge"), new RuleItem("X2", "Medium") });  //18
            rule18out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XXLarge") });

            rule19in.AddRange(new RuleItem[2] { new RuleItem("X1", "XSmall"), new RuleItem("X2", "Large") });  //19////
            rule19out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Large") });

            rule20in.AddRange(new RuleItem[2] { new RuleItem("X1", "Small"), new RuleItem("X2", "Large") });  //20
            rule20out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Large") });

            rule21in.AddRange(new RuleItem[2] { new RuleItem("X1", "Medium"), new RuleItem("X2", "Large") });  //21
            rule21out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Large") });

            rule22in.AddRange(new RuleItem[2] { new RuleItem("X1", "Large"), new RuleItem("X2", "Large") });  //22
            rule22out.AddRange(new RuleItem[1] { new RuleItem("Y1", "Large") });

            rule23in.AddRange(new RuleItem[2] { new RuleItem("X1", "XLarge"), new RuleItem("X2", "Large") });  //23
            rule23out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XLarge") });

            rule24in.AddRange(new RuleItem[2] { new RuleItem("X1", "XXLarge"), new RuleItem("X2", "Large") });  //24
            rule24out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XXLarge") });

            rule25in.AddRange(new RuleItem[2] { new RuleItem("X1", "XSmall"), new RuleItem("X2", "XLarge") });  //25
            rule25out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XLarge") });

            rule26in.AddRange(new RuleItem[2] { new RuleItem("X1", "Small"), new RuleItem("X2", "XLarge") });  //26
            rule26out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XLarge") });

            rule27in.AddRange(new RuleItem[2] { new RuleItem("X1", "Medium"), new RuleItem("X2", "XLarge") });  //27
            rule27out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XLarge") });

            rule28in.AddRange(new RuleItem[2] { new RuleItem("X1", "Large"), new RuleItem("X2", "XLarge") }); //28
            rule28out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XLarge") });

            rule29in.AddRange(new RuleItem[2] { new RuleItem("X1", "XLarge"), new RuleItem("X2", "XLarge") });  //29
            rule29out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XLarge") });

            rule30in.AddRange(new RuleItem[2] { new RuleItem("X1", "XXLarge"), new RuleItem("X2", "XLarge") });  //30
            rule30out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XXLarge") });

            rule31in.AddRange(new RuleItem[2] { new RuleItem("X1", "XSmall"), new RuleItem("X2", "XXLarge") });  //31
            rule31out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XXLarge") });

            rule32in.AddRange(new RuleItem[2] { new RuleItem("X1", "Small"), new RuleItem("X2", "XXLarge") }); //32
            rule32out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XXLarge") });

            rule33in.AddRange(new RuleItem[2] { new RuleItem("X1", "Medium"), new RuleItem("X2", "XXLarge") });  //33
            rule33out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XXLarge") });

            rule34in.AddRange(new RuleItem[2] { new RuleItem("X1", "Large"), new RuleItem("X2", "XXLarge") });  //34
            rule34out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XXLarge") });

            rule35in.AddRange(new RuleItem[2] { new RuleItem("X1", "XLarge"), new RuleItem("X2", "XXLarge") });  //35
            rule35out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XXLarge") });

            rule36in.AddRange(new RuleItem[2] { new RuleItem("X1", "XXLarge"), new RuleItem("X2", "XXLarge") });  //36
            rule36out.AddRange(new RuleItem[1] { new RuleItem("Y1", "XXLarge") });





            List<Rule> rules = new List<Rule>();
            FuzzyLogic.Rules.Add(new Rule(rule1in, rule1out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule2in, rule2out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule3in, rule3out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule4in, rule4out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule5in, rule5out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule6in, rule6out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule7in, rule7out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule8in, rule8out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule9in, rule9out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule10in, rule10out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule11in, rule11out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule12in, rule12out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule13in, rule13out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule14in, rule14out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule15in, rule15out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule16in, rule16out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule17in, rule17out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule18in, rule18out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule19in, rule19out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule20in, rule20out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule21in, rule21out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule22in, rule22out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule23in, rule23out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule24in, rule24out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule25in, rule25out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule26in, rule26out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule27in, rule27out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule28in, rule28out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule29in, rule29out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule30in, rule30out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule31in, rule31out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule32in, rule32out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule33in, rule33out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule34in, rule34out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule35in, rule35out, Connector.And));
            FuzzyLogic.Rules.Add(new Rule(rule36in, rule36out, Connector.And));



        }


        public static void FuzzyBMIndexOption()
        {

            // Inputs
            LingVariable XBMI1 = new LingVariable("XBMI1", VarType.Input);
            XBMI1.setRange(350, 1250);
            XBMI1.addMF(new Trapmf("LIGHT", 250, 450, 500, 650));
            //XBMI1.addMF(new Trimf("XOXO", 450, 550, 650));
            XBMI1.addMF(new Trimf("NORMAL", 600, 750, 850));
            //XBMI1.addMF(new Trimf("XOXO", 450, 550, 650));
            XBMI1.addMF(new Trapmf("WEIGHT", 750, 950, 1200, 1700));


            LingVariable XBMI2 = new LingVariable("XBMI2", VarType.Input);
            XBMI2.setRange(1200, 2400);
            XBMI2.addMF(new Trapmf("LOW", 1000, 1400, 1500, 1670));
            //XBMI2.addMF(new Trapmf("XOXO2", 0, 0, 1500, 1650));
            XBMI2.addMF(new Trimf("NORMAL", 1650, 1750, 1850));
            //XBMI2.addMF(new Trapmf("XOXO2", 0, 0, 1500, 1650));

            XBMI2.addMF(new Trapmf("HIGH", 1800, 1950, 2200, 2600));

            FuzzyLogic.InputVariablesBMI.Add(XBMI1);
            FuzzyLogic.InputVariablesBMI.Add(XBMI2);



            //Output
            LingVariable YBMI1 = new LingVariable("YBMI1", VarType.Output);
            YBMI1.setRange(16, 28);
            YBMI1.addMF(new Trapmf("VERYTHIN", 0, 15, 16, 17));
            YBMI1.addMF(new Trapmf("THIN", 16, 17, 17.5, 18.5));
            YBMI1.addMF(new Trapmf("NORMAL", 17.5, 18.5, 24, 25));
            YBMI1.addMF(new Trapmf("FAT", 24, 25, 26, 27));
            YBMI1.addMF(new Trapmf("VERYFAT", 26, 27, 28, 50));


            FuzzyLogic.OutputVariablesBMI.Add(YBMI1);
            //Rules
            List<RuleItem> rule1inBMI = new List<RuleItem>();
            List<RuleItem> rule1outBMI = new List<RuleItem>();
            List<RuleItem> rule2inBMI = new List<RuleItem>();
            List<RuleItem> rule2outBMI = new List<RuleItem>();
            List<RuleItem> rule3inBMI = new List<RuleItem>();
            List<RuleItem> rule3outBMI = new List<RuleItem>();
            List<RuleItem> rule4inBMI = new List<RuleItem>();
            List<RuleItem> rule4outBMI = new List<RuleItem>();
            List<RuleItem> rule5inBMI = new List<RuleItem>();
            List<RuleItem> rule5outBMI = new List<RuleItem>();
            List<RuleItem> rule6inBMI = new List<RuleItem>();
            List<RuleItem> rule6outBMI = new List<RuleItem>();
            List<RuleItem> rule7inBMI = new List<RuleItem>();
            List<RuleItem> rule7outBMI = new List<RuleItem>();
            List<RuleItem> rule8inBMI = new List<RuleItem>();
            List<RuleItem> rule8outBMI = new List<RuleItem>();
            List<RuleItem> rule9inBMI = new List<RuleItem>();
            List<RuleItem> rule9outBMI = new List<RuleItem>();




            rule1inBMI.AddRange(new RuleItem[2] { new RuleItem("XBMI1", "LIGHT"), new RuleItem("XBMI2", "LOW") }); //1
            rule1outBMI.AddRange(new RuleItem[1] { new RuleItem("YBMI1", "THIN") });

            rule2inBMI.AddRange(new RuleItem[2] { new RuleItem("XBMI1", "LIGHT"), new RuleItem("XBMI2", "NORMAL") });  //2
            rule2outBMI.AddRange(new RuleItem[1] { new RuleItem("YBMI1", "VERYTHIN") });

            rule3inBMI.AddRange(new RuleItem[2] { new RuleItem("XBMI1", "LIGHT"), new RuleItem("XBMI2", "HIGH") }); //3
            rule3outBMI.AddRange(new RuleItem[1] { new RuleItem("YBMI1", "VERYTHIN") });

            rule4inBMI.AddRange(new RuleItem[2] { new RuleItem("XBMI1", "NORMAL"), new RuleItem("XBMI2", "LOW") });  //4
            rule4outBMI.AddRange(new RuleItem[1] { new RuleItem("YBMI1", "NORMAL") });

            rule5inBMI.AddRange(new RuleItem[2] { new RuleItem("XBMI1", "NORMAL"), new RuleItem("XBMI2", "NORMAL") });  //5 
            rule5outBMI.AddRange(new RuleItem[1] { new RuleItem("YBMI1", "NORMAL") });

            rule6inBMI.AddRange(new RuleItem[2] { new RuleItem("XBMI1", "NORMAL"), new RuleItem("XBMI2", "HIGH") });  //6
            rule6outBMI.AddRange(new RuleItem[1] { new RuleItem("YBMI1", "THIN") });

            rule7inBMI.AddRange(new RuleItem[2] { new RuleItem("XBMI1", "WEIGHT"), new RuleItem("XBMI2", "LOW") }); //7
            rule7outBMI.AddRange(new RuleItem[1] { new RuleItem("YBMI1", "VERYFAT") });

            rule8inBMI.AddRange(new RuleItem[2] { new RuleItem("XBMI1", "WEIGHT"), new RuleItem("XBMI2", "NORMAL") });  //8
            rule8outBMI.AddRange(new RuleItem[1] { new RuleItem("YBMI1", "FAT") });

            rule9inBMI.AddRange(new RuleItem[2] { new RuleItem("XBMI1", "WEIGHT"), new RuleItem("XBMI2", "HIGH") });  //9
            rule9outBMI.AddRange(new RuleItem[1] { new RuleItem("YBMI1", "NORMAL") });






            List<Rule> rulesBMI = new List<Rule>();
            FuzzyLogic.RulesBMI.Add(new Rule(rule1inBMI, rule1outBMI, Connector.And));
            FuzzyLogic.RulesBMI.Add(new Rule(rule2inBMI, rule2outBMI, Connector.And));
            FuzzyLogic.RulesBMI.Add(new Rule(rule3inBMI, rule3outBMI, Connector.And));
            FuzzyLogic.RulesBMI.Add(new Rule(rule4inBMI, rule4outBMI, Connector.And));
            FuzzyLogic.RulesBMI.Add(new Rule(rule5inBMI, rule5outBMI, Connector.And));
            FuzzyLogic.RulesBMI.Add(new Rule(rule6inBMI, rule6outBMI, Connector.And));
            FuzzyLogic.RulesBMI.Add(new Rule(rule7inBMI, rule7outBMI, Connector.And));
            FuzzyLogic.RulesBMI.Add(new Rule(rule8inBMI, rule8outBMI, Connector.And));
            FuzzyLogic.RulesBMI.Add(new Rule(rule9inBMI, rule9outBMI, Connector.And));



        }

        public static LingVariable getVariablebyName(List<LingVariable> variable, String name)
        {
            return variable.Find(delegate (LingVariable n) { return n.Name == name; });
        }

        public static List<double> tokString(String Text)
        {
            List<double> list = new List<double>();
            StringTokenizer tok = new StringTokenizer(Text);
            tok.NewDelim(new char[] { ',' });

            String token;
            do
            {
                token = tok.NextToken();
                list.Add(Convert.ToDouble(token));

            } while (tok.HasMoreTokens());

            return list;
        }



    }
}
