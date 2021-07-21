using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPPV2.Abstract;

namespace TezAPPV2.Entities
{
    public class StandartDataInfo:IEntity
    {

        public int Id { get; set; }  //0
        public string Tc { get; set; }  //1
        public string Ad { get; set; } //2
        public string Soyad { get; set; }  //3
        public short A77 { get; set; }  //4
        public short A87 { get; set; }  //5
        public short A8 { get; set; }  //6
        public short E101 { get; set; }  //7
        public short E102 { get; set; }   //8
        public short E103 { get; set; }   //9
        public short A2Trium { get; set; } //17
        public short A3Trium { get; set; }//18
        public short A4Trium { get; set; }//19
        public short A5Trium { get; set; }//20
        public short A6Trium { get; set; }//21
        public short A7Trium { get; set; }//22
        public short A9Trium { get; set; }//23
        public short A12Trium { get; set; }//24
        public short A13Trium { get; set; }//25
        public short A17Trium { get; set; }//26
        public short A18Trium { get; set; }//27
        public short A19Trium { get; set; }//28
        public short A20Trium { get; set; }//29
        public short A21Trium { get; set; }//30
        public short A22Trium { get; set; }//31
        public short A23Trium { get; set; }//32
        public short A25Trium { get; set; }//33
        public short A26Trium { get; set; }//34
        public short A27Trium { get; set; }//35
        public short A28Trium { get; set; }//36
        public short A29Trium { get; set; }//37
        public short A30Trium { get; set; }//38
        public short A35Trium { get; set; }//39
        public short A36Trium { get; set; }//40
        public short A37Trium { get; set; }//41
        public short A38Trium { get; set; }//42
        public short A41Trium { get; set; }//43
        public short A42Trium { get; set; }//44
        public short A43Trium { get; set; }//45
        public short A44Trium { get; set; }//46
        public short A45Trium { get; set; }//47
        public short A49Trium { get; set; }//48
        public short A51Trium { get; set; }//49
        public short A52Trium { get; set; }//50
        public short A53Trium { get; set; }//51
        public short A55Trium { get; set; }//52
        public short A56Trium { get; set; }//53
        public short A57Trium { get; set; }//54
        public short A58Trium { get; set; }//55
        public short A59Trium { get; set; }//56
        public short A61Trium { get; set; }//57
        public short A66Trium { get; set; }//58
        public short A67Trium { get; set; }//59
        public short A68Trium { get; set; }//60
        public short A70Trium { get; set; }//61
        public short A71Trium { get; set; }//62
        public short A72Trium { get; set; }//63
        public short A73Trium { get; set; }//64
        public short A74Trium { get; set; }//65
        public short A75Trium { get; set; }//66
        public short A76Trium { get; set; }//67
        public short A78Trium { get; set; }//68
        public short A79Trium { get; set; }//69
        public short A80Trium { get; set; }//70
        public short A81Trium { get; set; }//71
        public short A82Trium { get; set; }//72
        public short A84Trium { get; set; }//73
        public short A85Trium { get; set; }//74
        public short A88Trium { get; set; }//75
        public short A89Trium { get; set; }//76
        public short A91Trium { get; set; }//77
        public short A93Trium { get; set; }//78
        public short A2Network { get; set; }//79
        public short A3Network { get; set; }//80
        public short A4Network { get; set; }//81
        public short A6Network { get; set; }//82
        public short A9Network { get; set; }//83
        public short A10Network { get; set; }//84
        public short A12Network { get; set; }//85
        public short A17Network { get; set; }//86
        public short A18Network { get; set; }//87
        public short A19Network { get; set; }//88
        public short A20Network { get; set; }//89
        public short A21Network { get; set; }//90
        public short A23Network { get; set; }//91
        public short A25Network { get; set; }//92
        public short A26Network { get; set; }//93
        public short A27Network { get; set; }//94
        public short A28Network { get; set; }//95
        public short A35Network { get; set; }//96
        public short A37Network { get; set; }//97
        public short A38Network { get; set; }//98
        public short A39Network { get; set; }//99
        public short A41Network { get; set; }//100
        public short A42Network { get; set; }//101
        public short A45Network { get; set; }//102
        public short A49Network { get; set; }//103
        public short A51Network { get; set; }//104
        public short A52Network { get; set; }//105
        public short A53Network { get; set; }//106
        public short A57Network { get; set; }//107
        public short A58Network { get; set; }//108
        public short A59Network { get; set; }//109
        public short A61Network { get; set; }//110
        public short A67Network { get; set; }//111
        public short A68Network { get; set; }//112
        public short A69Network { get; set; }//113
        public short A70Network { get; set; }//114
        public short A72Network { get; set; }//115
        public short A73Network { get; set; }//116
        public short A74Network { get; set; }//117
        public short A75Network { get; set; }//118
        public short A76Network { get; set; }//119
        public short A78Network { get; set; }//120
        public short A79Network { get; set; }//121
        public short A80Network { get; set; }//122
        public short A82Network { get; set; }//123
        public short A84Network { get; set; }//124
        public short A85Network { get; set; }//125
        public short A88Network { get; set; }//126
        public short A89Network { get; set; }//127
        public short A91Network { get; set; }//128
        public short A92Network { get; set; }//129
        public short A3Classic { get; set; }//130
        public short A4Classic { get; set; }//131
        public short A6Classic { get; set; }//132
        public short A19Classic { get; set; }//133
        public short A20Classic { get; set; }
        public short A21Classic { get; set; }
        public short A23Classic { get; set; }
        public short A27Classic { get; set; }
        public short A28Classic { get; set; }
        public short A35Classic { get; set; }
        public short A41Classic { get; set; }//140
        public short A42Classic { get; set; }
        public short A53Classic { get; set; }
        public short A57Classic { get; set; }
        public short A58Classic { get; set; }
        public short A59Classic { get; set; }
        public short A65Classic { get; set; }
        public short A68Classic { get; set; }
        public short A70Classic { get; set; }
        public short A72Classic { get; set; }
        public short A73Classic { get; set; }//150
        public short A74Classic { get; set; }
        public short A75Classic { get; set; }
        public short A77Classic { get; set; }
        public short A78Classic { get; set; }
        public short A82Classic { get; set; }
        public short A84Classic { get; set; }
        public short A91Classic { get; set; }
        public short A94Classic { get; set; }
        public string UstGiyimEbat { get; set; }//253
        public string PantolonEbat { get; set; }//255
        public string BotEbat { get; set; }//256
        public string EldivenEbat { get; set; }//257
        public string BMIndex { get; set; }//249
        public string BKoran { get; set; }//250
        public string Birlik { get; set; }//251
        public string Choosecmb { get; set; }//259
        public string chooseid { get; set; }//260

    }
}
