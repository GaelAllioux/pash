using System;
using System.Collections.Generic;
using System.Globalization;

namespace Microsoft.ActiveDirectory.TRLParser.LanguageParser.Parser
{
	internal class Parser : ShiftReduceParser<ValueType, LexLocation>
	{
		private Dictionary<int, string> TokenStrings;

		public Parser()
		{
			this.TokenStrings = new Dictionary<int, string>();
		}

		protected override void DoAction(int action)
		{
		}

		protected override void Initialize()
		{
			this.errToken = 1;
			this.eofToken = 2;
			this.states = new State[93];
			int[] numArray = new int[] { 17, 61, 3, 89, 2, -2, 7, -8 };
			int[] numArray1 = new int[] { -1, 1, -3, 3, -4, 92, -5, 5, -6, 6, -8, 56, -9, 59, -10, 60 };
			base.AddState(0, new State(numArray, numArray1));
			int[] numArray2 = new int[2];
			numArray2[0] = 2;
			numArray2[1] = 2;
			base.AddState(1, new State(numArray2));
			base.AddState(2, new State(-1));
			int[] numArray3 = new int[] { 17, 61, 3, 89, 2, -3, 7, -8 };
			int[] numArray4 = new int[] { -4, 4, -5, 5, -6, 6, -8, 56, -9, 59, -10, 60 };
			base.AddState(3, new State(numArray3, numArray4));
			base.AddState(4, new State(-5));
			base.AddState(5, new State(-6));
			int[] numArray5 = new int[2];
			numArray5[0] = 7;
			numArray5[1] = 7;
			base.AddState(6, new State(numArray5));
			int[] numArray6 = new int[2];
			numArray6[0] = 5;
			numArray6[1] = 10;
			int[] numArray7 = new int[2];
			numArray7[0] = -7;
			numArray7[1] = 8;
			base.AddState(7, new State(numArray6, numArray7));
			int[] numArray8 = new int[2];
			numArray8[0] = 13;
			numArray8[1] = 9;
			base.AddState(8, new State(numArray8));
			base.AddState(9, new State(-7));
			int[] numArray9 = new int[2];
			numArray9[0] = 19;
			numArray9[1] = 11;
			base.AddState(10, new State(numArray9));
			int[] numArray10 = new int[] { 12, 15, 9, 37, 10, 26, 8, 52 };
			int[] numArray11 = new int[] { -24, 12, -25, 14, -26, 18, -27, 19, -28, 55, -29, 22, -31, 23, -32, 48, -30, 51 };
			base.AddState(11, new State(numArray10, numArray11));
			int[] numArray12 = new int[2];
			numArray12[0] = 20;
			numArray12[1] = 13;
			base.AddState(12, new State(numArray12));
			base.AddState(13, new State(-42));
			base.AddState(14, new State(-43));
			int[] numArray13 = new int[2];
			numArray13[0] = 29;
			numArray13[1] = 16;
			base.AddState(15, new State(numArray13));
			int[] numArray14 = new int[2];
			numArray14[0] = 3;
			numArray14[1] = 17;
			base.AddState(16, new State(numArray14));
			base.AddState(17, new State(-45));
			base.AddState(18, new State(-44));
			int[] numArray15 = new int[] { 15, 20, 20, -46 };
			base.AddState(19, new State(numArray15));
			int[] numArray16 = new int[] { 9, 37, 10, 26, 8, 52 };
			int[] numArray17 = new int[] { -28, 21, -29, 22, -31, 23, -32, 48, -30, 51 };
			base.AddState(20, new State(numArray16, numArray17));
			base.AddState(21, new State(-48));
			base.AddState(22, new State(-49));
			int[] numArray18 = new int[2];
			numArray18[0] = 15;
			numArray18[1] = 24;
			base.AddState(23, new State(numArray18));
			int[] numArray19 = new int[2];
			numArray19[0] = 10;
			numArray19[1] = 26;
			int[] numArray20 = new int[2];
			numArray20[0] = -32;
			numArray20[1] = 25;
			base.AddState(24, new State(numArray19, numArray20));
			base.AddState(25, new State(-51));
			int[] numArray21 = new int[2];
			numArray21[0] = 29;
			numArray21[1] = 27;
			base.AddState(26, new State(numArray21));
			int[] numArray22 = new int[] { 21, 30, 22, 31, 23, 32, 24, 33, 3, 34 };
			int[] numArray23 = new int[] { -20, 28, -23, 29 };
			base.AddState(27, new State(numArray22, numArray23));
			base.AddState(28, new State(-54));
			base.AddState(29, new State(-35));
			base.AddState(30, new State(-37));
			base.AddState(31, new State(-38));
			base.AddState(32, new State(-39));
			base.AddState(33, new State(-40));
			int[] numArray24 = new int[2];
			numArray24[0] = 16;
			numArray24[1] = 35;
			base.AddState(34, new State(numArray24));
			int[] numArray25 = new int[2];
			numArray25[0] = 10;
			numArray25[1] = 36;
			base.AddState(35, new State(numArray25));
			base.AddState(36, new State(-36));
			int[] numArray26 = new int[2];
			numArray26[0] = 29;
			numArray26[1] = 38;
			base.AddState(37, new State(numArray26));
			int[] numArray27 = new int[] { 4, 41, 21, 30, 22, 31, 23, 32, 24, 33, 3, 43 };
			int[] numArray28 = new int[] { -17, 39, -22, 40, -20, 42, -23, 29 };
			base.AddState(38, new State(numArray27, numArray28));
			base.AddState(39, new State(-53));
			base.AddState(40, new State(-32));
			base.AddState(41, new State(-41));
			base.AddState(42, new State(-33));
			int[] numArray29 = new int[2];
			numArray29[0] = 16;
			numArray29[1] = 44;
			base.AddState(43, new State(numArray29));
			int[] numArray30 = new int[] { 10, 36, 8, 46, 9, 47 };
			int[] numArray31 = new int[2];
			numArray31[0] = -21;
			numArray31[1] = 45;
			base.AddState(44, new State(numArray30, numArray31));
			base.AddState(45, new State(-34));
			base.AddState(46, new State(-26));
			base.AddState(47, new State(-27));
			int[] numArray32 = new int[2];
			numArray32[0] = 15;
			numArray32[1] = 49;
			base.AddState(48, new State(numArray32));
			int[] numArray33 = new int[2];
			numArray33[0] = 9;
			numArray33[1] = 37;
			int[] numArray34 = new int[2];
			numArray34[0] = -31;
			numArray34[1] = 50;
			base.AddState(49, new State(numArray33, numArray34));
			base.AddState(50, new State(-52));
			base.AddState(51, new State(-50));
			int[] numArray35 = new int[2];
			numArray35[0] = 29;
			numArray35[1] = 53;
			base.AddState(52, new State(numArray35));
			int[] numArray36 = new int[] { 4, 41, 21, 30, 22, 31, 23, 32, 24, 33, 3, 43 };
			int[] numArray37 = new int[] { -17, 54, -22, 40, -20, 42, -23, 29 };
			base.AddState(53, new State(numArray36, numArray37));
			base.AddState(54, new State(-55));
			base.AddState(55, new State(-47));
			int[] numArray38 = new int[] { 30, 57, 7, -9 };
			base.AddState(56, new State(numArray38));
			int[] numArray39 = new int[] { 17, 61, 3, 89 };
			int[] numArray40 = new int[] { -8, 58, -9, 59, -10, 60 };
			base.AddState(57, new State(numArray39, numArray40));
			base.AddState(58, new State(-11));
			base.AddState(59, new State(-10));
			base.AddState(60, new State(-12));
			int[] numArray41 = new int[] { 9, 78, 10, 71, 8, 85, 18, -15 };
			int[] numArray42 = new int[] { -11, 62, -12, 64, -13, 88, -14, 67, -18, 68, -19, 81, -15, 84 };
			base.AddState(61, new State(numArray41, numArray42));
			int[] numArray43 = new int[2];
			numArray43[0] = 18;
			numArray43[1] = 63;
			base.AddState(62, new State(numArray43));
			base.AddState(63, new State(-14));
			int[] numArray44 = new int[] { 15, 65, 18, -16 };
			base.AddState(64, new State(numArray44));
			int[] numArray45 = new int[] { 9, 78, 10, 71, 8, 85 };
			int[] numArray46 = new int[] { -13, 66, -14, 67, -18, 68, -19, 81, -15, 84 };
			base.AddState(65, new State(numArray45, numArray46));
			base.AddState(66, new State(-18));
			base.AddState(67, new State(-19));
			int[] numArray47 = new int[2];
			numArray47[0] = 15;
			numArray47[1] = 69;
			base.AddState(68, new State(numArray47));
			int[] numArray48 = new int[2];
			numArray48[0] = 10;
			numArray48[1] = 71;
			int[] numArray49 = new int[2];
			numArray49[0] = -19;
			numArray49[1] = 70;
			base.AddState(69, new State(numArray48, numArray49));
			base.AddState(70, new State(-22));
			int[] numArray50 = new int[] { 25, 74, 26, 75, 27, 76, 28, 77 };
			int[] numArray51 = new int[2];
			numArray51[0] = -16;
			numArray51[1] = 72;
			base.AddState(71, new State(numArray50, numArray51));
			int[] numArray52 = new int[] { 21, 30, 22, 31, 23, 32, 24, 33, 3, 34 };
			int[] numArray53 = new int[] { -20, 73, -23, 29 };
			base.AddState(72, new State(numArray52, numArray53));
			base.AddState(73, new State(-25));
			base.AddState(74, new State(-28));
			base.AddState(75, new State(-29));
			base.AddState(76, new State(-30));
			base.AddState(77, new State(-31));
			int[] numArray54 = new int[] { 25, 74, 26, 75, 27, 76, 28, 77 };
			int[] numArray55 = new int[2];
			numArray55[0] = -16;
			numArray55[1] = 79;
			base.AddState(78, new State(numArray54, numArray55));
			int[] numArray56 = new int[] { 4, 41, 21, 30, 22, 31, 23, 32, 24, 33, 3, 43 };
			int[] numArray57 = new int[] { -17, 80, -22, 40, -20, 42, -23, 29 };
			base.AddState(79, new State(numArray56, numArray57));
			base.AddState(80, new State(-24));
			int[] numArray58 = new int[2];
			numArray58[0] = 15;
			numArray58[1] = 82;
			base.AddState(81, new State(numArray58));
			int[] numArray59 = new int[2];
			numArray59[0] = 9;
			numArray59[1] = 78;
			int[] numArray60 = new int[2];
			numArray60[0] = -18;
			numArray60[1] = 83;
			base.AddState(82, new State(numArray59, numArray60));
			base.AddState(83, new State(-23));
			base.AddState(84, new State(-20));
			int[] numArray61 = new int[] { 25, 74, 26, 75, 27, 76, 28, 77 };
			int[] numArray62 = new int[2];
			numArray62[0] = -16;
			numArray62[1] = 86;
			base.AddState(85, new State(numArray61, numArray62));
			int[] numArray63 = new int[] { 4, 41, 21, 30, 22, 31, 23, 32, 24, 33, 3, 43 };
			int[] numArray64 = new int[] { -17, 87, -22, 40, -20, 42, -23, 29 };
			base.AddState(86, new State(numArray63, numArray64));
			base.AddState(87, new State(-21));
			base.AddState(88, new State(-17));
			int[] numArray65 = new int[2];
			numArray65[0] = 14;
			numArray65[1] = 90;
			base.AddState(89, new State(numArray65));
			int[] numArray66 = new int[2];
			numArray66[0] = 17;
			numArray66[1] = 61;
			int[] numArray67 = new int[2];
			numArray67[0] = -10;
			numArray67[1] = 91;
			base.AddState(90, new State(numArray66, numArray67));
			base.AddState(91, new State(-13));
			base.AddState(92, new State(-4));
			this.rules = new Rule[56];
			int[] numArray68 = new int[2];
			numArray68[0] = -1;
			numArray68[1] = 2;
			this.rules[1] = new Rule(-2, numArray68);
			this.rules[2] = new Rule(-1, new int[0]);
			int[] numArray69 = new int[1];
			numArray69[0] = -3;
			this.rules[3] = new Rule(-1, numArray69);
			int[] numArray70 = new int[1];
			numArray70[0] = -4;
			this.rules[4] = new Rule(-3, numArray70);
			int[] numArray71 = new int[2];
			numArray71[0] = -3;
			numArray71[1] = -4;
			this.rules[5] = new Rule(-3, numArray71);
			int[] numArray72 = new int[1];
			numArray72[0] = -5;
			this.rules[6] = new Rule(-4, numArray72);
			int[] numArray73 = new int[] { -6, 7, -7, 13 };
			this.rules[7] = new Rule(-5, numArray73);
			this.rules[8] = new Rule(-6, new int[0]);
			int[] numArray74 = new int[1];
			numArray74[0] = -8;
			this.rules[9] = new Rule(-6, numArray74);
			int[] numArray75 = new int[1];
			numArray75[0] = -9;
			this.rules[10] = new Rule(-8, numArray75);
			int[] numArray76 = new int[] { -8, 30, -8 };
			this.rules[11] = new Rule(-8, numArray76);
			int[] numArray77 = new int[1];
			numArray77[0] = -10;
			this.rules[12] = new Rule(-9, numArray77);
			int[] numArray78 = new int[] { 3, 14, -10 };
			this.rules[13] = new Rule(-9, numArray78);
			int[] numArray79 = new int[] { 17, -11, 18 };
			this.rules[14] = new Rule(-10, numArray79);
			this.rules[15] = new Rule(-11, new int[0]);
			int[] numArray80 = new int[1];
			numArray80[0] = -12;
			this.rules[16] = new Rule(-11, numArray80);
			int[] numArray81 = new int[1];
			numArray81[0] = -13;
			this.rules[17] = new Rule(-12, numArray81);
			int[] numArray82 = new int[] { -12, 15, -13 };
			this.rules[18] = new Rule(-12, numArray82);
			int[] numArray83 = new int[1];
			numArray83[0] = -14;
			this.rules[19] = new Rule(-13, numArray83);
			int[] numArray84 = new int[1];
			numArray84[0] = -15;
			this.rules[20] = new Rule(-13, numArray84);
			int[] numArray85 = new int[] { 8, -16, -17 };
			this.rules[21] = new Rule(-15, numArray85);
			int[] numArray86 = new int[] { -18, 15, -19 };
			this.rules[22] = new Rule(-14, numArray86);
			int[] numArray87 = new int[] { -19, 15, -18 };
			this.rules[23] = new Rule(-14, numArray87);
			int[] numArray88 = new int[] { 9, -16, -17 };
			this.rules[24] = new Rule(-18, numArray88);
			int[] numArray89 = new int[] { 10, -16, -20 };
			this.rules[25] = new Rule(-19, numArray89);
			int[] numArray90 = new int[1];
			numArray90[0] = 8;
			this.rules[26] = new Rule(-21, numArray90);
			int[] numArray91 = new int[1];
			numArray91[0] = 9;
			this.rules[27] = new Rule(-21, numArray91);
			int[] numArray92 = new int[1];
			numArray92[0] = 25;
			this.rules[28] = new Rule(-16, numArray92);
			int[] numArray93 = new int[1];
			numArray93[0] = 26;
			this.rules[29] = new Rule(-16, numArray93);
			int[] numArray94 = new int[1];
			numArray94[0] = 27;
			this.rules[30] = new Rule(-16, numArray94);
			int[] numArray95 = new int[1];
			numArray95[0] = 28;
			this.rules[31] = new Rule(-16, numArray95);
			int[] numArray96 = new int[1];
			numArray96[0] = -22;
			this.rules[32] = new Rule(-17, numArray96);
			int[] numArray97 = new int[1];
			numArray97[0] = -20;
			this.rules[33] = new Rule(-17, numArray97);
			int[] numArray98 = new int[] { 3, 16, -21 };
			this.rules[34] = new Rule(-17, numArray98);
			int[] numArray99 = new int[1];
			numArray99[0] = -23;
			this.rules[35] = new Rule(-20, numArray99);
			int[] numArray100 = new int[] { 3, 16, 10 };
			this.rules[36] = new Rule(-20, numArray100);
			int[] numArray101 = new int[1];
			numArray101[0] = 21;
			this.rules[37] = new Rule(-23, numArray101);
			int[] numArray102 = new int[1];
			numArray102[0] = 22;
			this.rules[38] = new Rule(-23, numArray102);
			int[] numArray103 = new int[1];
			numArray103[0] = 23;
			this.rules[39] = new Rule(-23, numArray103);
			int[] numArray104 = new int[1];
			numArray104[0] = 24;
			this.rules[40] = new Rule(-23, numArray104);
			int[] numArray105 = new int[1];
			numArray105[0] = 4;
			this.rules[41] = new Rule(-22, numArray105);
			int[] numArray106 = new int[] { 5, 19, -24, 20 };
			this.rules[42] = new Rule(-7, numArray106);
			numArray2 = new int[1];
			numArray2[0] = -25;
			this.rules[43] = new Rule(-24, numArray2);
			numArray2 = new int[1];
			numArray2[0] = -26;
			this.rules[44] = new Rule(-24, numArray2);
			int[] numArray107 = new int[] { 12, 29, 3 };
			this.rules[45] = new Rule(-25, numArray107);
			numArray2 = new int[1];
			numArray2[0] = -27;
			this.rules[46] = new Rule(-26, numArray2);
			numArray2 = new int[1];
			numArray2[0] = -28;
			this.rules[47] = new Rule(-27, numArray2);
			int[] numArray108 = new int[] { -27, 15, -28 };
			this.rules[48] = new Rule(-27, numArray108);
			numArray2 = new int[1];
			numArray2[0] = -29;
			this.rules[49] = new Rule(-28, numArray2);
			numArray2 = new int[1];
			numArray2[0] = -30;
			this.rules[50] = new Rule(-28, numArray2);
			int[] numArray109 = new int[] { -31, 15, -32 };
			this.rules[51] = new Rule(-29, numArray109);
			int[] numArray110 = new int[] { -32, 15, -31 };
			this.rules[52] = new Rule(-29, numArray110);
			int[] numArray111 = new int[] { 9, 29, -17 };
			this.rules[53] = new Rule(-31, numArray111);
			int[] numArray112 = new int[] { 10, 29, -20 };
			this.rules[54] = new Rule(-32, numArray112);
			int[] numArray113 = new int[] { 8, 29, -17 };
			this.rules[55] = new Rule(-30, numArray113);
			string[] strArrays = new string[33];
			strArrays[0] = "";
			strArrays[1] = "program";
			strArrays[2] = "$accept";
			strArrays[3] = "rules";
			strArrays[4] = "rule";
			strArrays[5] = "rule_body";
			strArrays[6] = "conditions";
			strArrays[7] = "rule_action";
			strArrays[8] = "sel_condition_list";
			strArrays[9] = "sel_condition";
			strArrays[10] = "sel_condition_body";
			strArrays[11] = "opt_cond_list";
			strArrays[12] = "cond_list";
			strArrays[13] = "cond";
			strArrays[14] = "value_cond";
			strArrays[15] = "type_cond";
			strArrays[16] = "cond_oper";
			strArrays[17] = "expr";
			strArrays[18] = "val_cond";
			strArrays[19] = "val_type_cond";
			strArrays[20] = "value_type_expr";
			strArrays[21] = "claim_prop";
			strArrays[22] = "literal";
			strArrays[23] = "value_type_literal";
			strArrays[24] = "issue_params";
			strArrays[25] = "claim_copy";
			strArrays[26] = "claim_new";
			strArrays[27] = "claim_prop_assign_list";
			strArrays[28] = "claim_prop_assign";
			strArrays[29] = "claim_value_assign";
			strArrays[30] = "claim_type_assign";
			strArrays[31] = "claim_val_assign";
			strArrays[32] = "claim_val_type_assign";
			this.nonTerminals = strArrays;
			this.TokenStringsInit();
		}

		protected override string TerminalToString(int terminal)
		{
			string str = null;
			if (terminal.ToString() == terminal.ToString(CultureInfo.InvariantCulture))
			{
				str = base.CharToString(Convert.ToChar ((ushort)terminal));
			}
			else
			{
				try
				{
					this.TokenStrings.TryGetValue(terminal, out str);
				}
				catch (ArgumentNullException argumentNullException)
				{
				}
				if (str == null)
				{
					str = terminal.ToString();
				}
			}
			return string.Concat("'", str, "'");
		}

		private void TokenStringsInit()
		{
			this.TokenStrings.Add(7, "=>");
			this.TokenStrings.Add(13, ";");
			this.TokenStrings.Add(14, ":");
			this.TokenStrings.Add(15, ",");
			this.TokenStrings.Add(16, ".");
			this.TokenStrings.Add(17, "[");
			this.TokenStrings.Add(18, "]");
			this.TokenStrings.Add(19, "(");
			this.TokenStrings.Add(20, ")");
			this.TokenStrings.Add(25, "==");
			this.TokenStrings.Add(26, "!=");
			this.TokenStrings.Add(27, "=~");
			this.TokenStrings.Add(28, "!~");
			this.TokenStrings.Add(29, "=");
			this.TokenStrings.Add(30, "&&");
			this.TokenStrings.Add(21, "int64");
			this.TokenStrings.Add(22, "uint64");
			this.TokenStrings.Add(24, "boolean");
			this.TokenStrings.Add(23, "string");
			this.TokenStrings.Add(8, "type");
			this.TokenStrings.Add(9, "value");
			this.TokenStrings.Add(10, "valuetype");
			this.TokenStrings.Add(5, "issue");
			this.TokenStrings.Add(12, "claim");
		}
	}
}