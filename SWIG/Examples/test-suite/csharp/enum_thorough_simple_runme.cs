using System;
using enum_thorough_simpleNamespace;

public class runme {
  static void Main() {
    {
      // Anonymous enums
      int i = enum_thorough_simple.AnonEnum1;
      if (enum_thorough_simple.ReallyAnInteger != 200) throw new Exception("Test Anon 1 failed");
      int j = enum_thorough_simple.AnonSpaceEnum1;
      int k = AnonStruct.AnonStructEnum1;
    }
    {
      int red = enum_thorough_simple.red;
      enum_thorough_simple.colourTest1(red);
      enum_thorough_simple.colourTest2(red);
      enum_thorough_simple.colourTest3(red);
      enum_thorough_simple.colourTest4(red);
      enum_thorough_simple.myColour = red;
    }
    {
      SpeedClass s = new SpeedClass();
      int speed = SpeedClass.slow;
      if (s.speedTest1(speed) != speed) throw new Exception("speedTest 1 failed");
      if (s.speedTest2(speed) != speed) throw new Exception("speedTest 2 failed");
      if (s.speedTest3(speed) != speed) throw new Exception("speedTest 3 failed");
      if (s.speedTest4(speed) != speed) throw new Exception("speedTest 4 failed");
      if (s.speedTest5(speed) != speed) throw new Exception("speedTest 5 failed");
      if (s.speedTest6(speed) != speed) throw new Exception("speedTest 6 failed");

      if (enum_thorough_simple.speedTest1(speed) != speed) throw new Exception("speedTest Global 1 failed");
      if (enum_thorough_simple.speedTest2(speed) != speed) throw new Exception("speedTest Global 2 failed");
      if (enum_thorough_simple.speedTest3(speed) != speed) throw new Exception("speedTest Global 3 failed");
      if (enum_thorough_simple.speedTest4(speed) != speed) throw new Exception("speedTest Global 4 failed");
    }
    {
      SpeedClass s = new SpeedClass();
      int slow = SpeedClass.slow;
      int lightning = SpeedClass.lightning;

      if (s.mySpeedtd1 != slow) throw new Exception("mySpeedtd1 1 failed");
      if (s.mySpeedtd1 != 10) throw new Exception("mySpeedtd1 2 failed");

      s.mySpeedtd1 = lightning;
      if (s.mySpeedtd1 != lightning) throw new Exception("mySpeedtd1 3 failed");
      if (s.mySpeedtd1 != 31) throw new Exception("mySpeedtd1 4 failed");
    }
    {
      if (enum_thorough_simple.namedanonTest1(enum_thorough_simple.NamedAnon2) != enum_thorough_simple.NamedAnon2) throw new Exception("namedanonTest 1 failed");
    }
    {
      int val = enum_thorough_simple.TwoNames2;
      if (enum_thorough_simple.twonamesTest1(val) != val) throw new Exception("twonamesTest 1 failed");
      if (enum_thorough_simple.twonamesTest2(val) != val) throw new Exception("twonamesTest 2 failed");
      if (enum_thorough_simple.twonamesTest3(val) != val) throw new Exception("twonamesTest 3 failed");
    }
    {
      TwoNamesStruct t = new TwoNamesStruct();
      int val = TwoNamesStruct.TwoNamesStruct1;
      if (t.twonamesTest1(val) != val) throw new Exception("twonamesTest 1 failed");
      if (t.twonamesTest2(val) != val) throw new Exception("twonamesTest 2 failed");
      if (t.twonamesTest3(val) != val) throw new Exception("twonamesTest 3 failed");
    }
    {
      int val = enum_thorough_simple.NamedAnonSpace2;
      if (enum_thorough_simple.namedanonspaceTest1(val) != val) throw new Exception("namedanonspaceTest 1 failed");
      if (enum_thorough_simple.namedanonspaceTest2(val) != val) throw new Exception("namedanonspaceTest 2 failed");
      if (enum_thorough_simple.namedanonspaceTest3(val) != val) throw new Exception("namedanonspaceTest 3 failed");
      if (enum_thorough_simple.namedanonspaceTest4(val) != val) throw new Exception("namedanonspaceTest 4 failed");
    }
    {
      TemplateClassInt t = new TemplateClassInt();
      int galileo = TemplateClassInt.galileo;

      if (t.scientistsTest1(galileo) != galileo) throw new Exception("scientistsTest 1 failed");
      if (t.scientistsTest2(galileo) != galileo) throw new Exception("scientistsTest 2 failed");
      if (t.scientistsTest3(galileo) != galileo) throw new Exception("scientistsTest 3 failed");
      if (t.scientistsTest4(galileo) != galileo) throw new Exception("scientistsTest 4 failed");
      if (t.scientistsTest5(galileo) != galileo) throw new Exception("scientistsTest 5 failed");
      if (t.scientistsTest6(galileo) != galileo) throw new Exception("scientistsTest 6 failed");
      if (t.scientistsTest7(galileo) != galileo) throw new Exception("scientistsTest 7 failed");
      if (t.scientistsTest8(galileo) != galileo) throw new Exception("scientistsTest 8 failed");
      if (t.scientistsTest9(galileo) != galileo) throw new Exception("scientistsTest 9 failed");
//      if (t.scientistsTestA(galileo) != galileo) throw new Exception("scientistsTest A failed");
      if (t.scientistsTestB(galileo) != galileo) throw new Exception("scientistsTest B failed");
//      if (t.scientistsTestC(galileo) != galileo) throw new Exception("scientistsTest C failed");
      if (t.scientistsTestD(galileo) != galileo) throw new Exception("scientistsTest D failed");
      if (t.scientistsTestE(galileo) != galileo) throw new Exception("scientistsTest E failed");
      if (t.scientistsTestF(galileo) != galileo) throw new Exception("scientistsTest F failed");
      if (t.scientistsTestG(galileo) != galileo) throw new Exception("scientistsTest G failed");
      if (t.scientistsTestH(galileo) != galileo) throw new Exception("scientistsTest H failed");
      if (t.scientistsTestI(galileo) != galileo) throw new Exception("scientistsTest I failed");

      if (enum_thorough_simple.scientistsTest1(galileo) != galileo) throw new Exception("scientistsTest Global 1 failed");
      if (enum_thorough_simple.scientistsTest2(galileo) != galileo) throw new Exception("scientistsTest Global 2 failed");
      if (enum_thorough_simple.scientistsTest3(galileo) != galileo) throw new Exception("scientistsTest Global 3 failed");
      if (enum_thorough_simple.scientistsTest4(galileo) != galileo) throw new Exception("scientistsTest Global 4 failed");
      if (enum_thorough_simple.scientistsTest5(galileo) != galileo) throw new Exception("scientistsTest Global 5 failed");
      if (enum_thorough_simple.scientistsTest6(galileo) != galileo) throw new Exception("scientistsTest Global 6 failed");
      if (enum_thorough_simple.scientistsTest7(galileo) != galileo) throw new Exception("scientistsTest Global 7 failed");
    }
    {
      TClassInt t = new TClassInt();
      int bell = TClassInt.bell;
      int galileo = TemplateClassInt.galileo;
      if (t.scientistsNameTest1(bell) != bell) throw new Exception("scientistsNameTest 1 failed");
      if (t.scientistsNameTest2(bell) != bell) throw new Exception("scientistsNameTest 2 failed");
      if (t.scientistsNameTest3(bell) != bell) throw new Exception("scientistsNameTest 3 failed");
      if (t.scientistsNameTest4(bell) != bell) throw new Exception("scientistsNameTest 4 failed");
      if (t.scientistsNameTest5(bell) != bell) throw new Exception("scientistsNameTest 5 failed");
      if (t.scientistsNameTest6(bell) != bell) throw new Exception("scientistsNameTest 6 failed");
      if (t.scientistsNameTest7(bell) != bell) throw new Exception("scientistsNameTest 7 failed");
      if (t.scientistsNameTest8(bell) != bell) throw new Exception("scientistsNameTest 8 failed");
      if (t.scientistsNameTest9(bell) != bell) throw new Exception("scientistsNameTest 9 failed");
//      if (t.scientistsNameTestA(bell) != bell) throw new Exception("scientistsNameTest A failed");
      if (t.scientistsNameTestB(bell) != bell) throw new Exception("scientistsNameTest B failed");
//      if (t.scientistsNameTestC(bell) != bell) throw new Exception("scientistsNameTest C failed");
      if (t.scientistsNameTestD(bell) != bell) throw new Exception("scientistsNameTest D failed");
      if (t.scientistsNameTestE(bell) != bell) throw new Exception("scientistsNameTest E failed");
      if (t.scientistsNameTestF(bell) != bell) throw new Exception("scientistsNameTest F failed");
      if (t.scientistsNameTestG(bell) != bell) throw new Exception("scientistsNameTest G failed");
      if (t.scientistsNameTestH(bell) != bell) throw new Exception("scientistsNameTest H failed");
      if (t.scientistsNameTestI(bell) != bell) throw new Exception("scientistsNameTest I failed");

      if (t.scientistsNameSpaceTest1(bell) != bell) throw new Exception("scientistsNameSpaceTest 1 failed");
      if (t.scientistsNameSpaceTest2(bell) != bell) throw new Exception("scientistsNameSpaceTest 2 failed");
      if (t.scientistsNameSpaceTest3(bell) != bell) throw new Exception("scientistsNameSpaceTest 3 failed");
      if (t.scientistsNameSpaceTest4(bell) != bell) throw new Exception("scientistsNameSpaceTest 4 failed");
      if (t.scientistsNameSpaceTest5(bell) != bell) throw new Exception("scientistsNameSpaceTest 5 failed");
      if (t.scientistsNameSpaceTest6(bell) != bell) throw new Exception("scientistsNameSpaceTest 6 failed");
      if (t.scientistsNameSpaceTest7(bell) != bell) throw new Exception("scientistsNameSpaceTest 7 failed");

      if (t.scientistsOtherTest1(galileo) != galileo) throw new Exception("scientistsOtherTest 1 failed");
      if (t.scientistsOtherTest2(galileo) != galileo) throw new Exception("scientistsOtherTest 2 failed");
      if (t.scientistsOtherTest3(galileo) != galileo) throw new Exception("scientistsOtherTest 3 failed");
      if (t.scientistsOtherTest4(galileo) != galileo) throw new Exception("scientistsOtherTest 4 failed");
      if (t.scientistsOtherTest5(galileo) != galileo) throw new Exception("scientistsOtherTest 5 failed");
      if (t.scientistsOtherTest6(galileo) != galileo) throw new Exception("scientistsOtherTest 6 failed");
      if (t.scientistsOtherTest7(galileo) != galileo) throw new Exception("scientistsOtherTest 7 failed");

      if (enum_thorough_simple.scientistsNameTest1(bell) != bell) throw new Exception("scientistsNameTest Global 1 failed");
      if (enum_thorough_simple.scientistsNameTest2(bell) != bell) throw new Exception("scientistsNameTest Global 2 failed");
      if (enum_thorough_simple.scientistsNameTest3(bell) != bell) throw new Exception("scientistsNameTest Global 3 failed");
      if (enum_thorough_simple.scientistsNameTest4(bell) != bell) throw new Exception("scientistsNameTest Global 4 failed");
      if (enum_thorough_simple.scientistsNameTest5(bell) != bell) throw new Exception("scientistsNameTest Global 5 failed");
      if (enum_thorough_simple.scientistsNameTest6(bell) != bell) throw new Exception("scientistsNameTest Global 6 failed");
      if (enum_thorough_simple.scientistsNameTest7(bell) != bell) throw new Exception("scientistsNameTest Global 7 failed");

      if (enum_thorough_simple.scientistsNameSpaceTest1(bell) != bell) throw new Exception("scientistsNameSpaceTest Global 1 failed");
      if (enum_thorough_simple.scientistsNameSpaceTest2(bell) != bell) throw new Exception("scientistsNameSpaceTest Global 2 failed");
      if (enum_thorough_simple.scientistsNameSpaceTest3(bell) != bell) throw new Exception("scientistsNameSpaceTest Global 3 failed");
      if (enum_thorough_simple.scientistsNameSpaceTest4(bell) != bell) throw new Exception("scientistsNameSpaceTest Global 4 failed");
      if (enum_thorough_simple.scientistsNameSpaceTest5(bell) != bell) throw new Exception("scientistsNameSpaceTest Global 5 failed");
      if (enum_thorough_simple.scientistsNameSpaceTest6(bell) != bell) throw new Exception("scientistsNameSpaceTest Global 6 failed");
      if (enum_thorough_simple.scientistsNameSpaceTest7(bell) != bell) throw new Exception("scientistsNameSpaceTest Global 7 failed");

      if (enum_thorough_simple.scientistsNameSpaceTest8(bell) != bell) throw new Exception("scientistsNameSpaceTest Global 8 failed");
      if (enum_thorough_simple.scientistsNameSpaceTest9(bell) != bell) throw new Exception("scientistsNameSpaceTest Global 9 failed");
      if (enum_thorough_simple.scientistsNameSpaceTestA(bell) != bell) throw new Exception("scientistsNameSpaceTest Global A failed");
      if (enum_thorough_simple.scientistsNameSpaceTestB(bell) != bell) throw new Exception("scientistsNameSpaceTest Global B failed");
      if (enum_thorough_simple.scientistsNameSpaceTestC(bell) != bell) throw new Exception("scientistsNameSpaceTest Global C failed");
      if (enum_thorough_simple.scientistsNameSpaceTestD(bell) != bell) throw new Exception("scientistsNameSpaceTest Global D failed");
      if (enum_thorough_simple.scientistsNameSpaceTestE(bell) != bell) throw new Exception("scientistsNameSpaceTest Global E failed");

      if (enum_thorough_simple.scientistsNameSpaceTestF(bell) != bell) throw new Exception("scientistsNameSpaceTest Global F failed");
      if (enum_thorough_simple.scientistsNameSpaceTestG(bell) != bell) throw new Exception("scientistsNameSpaceTest Global G failed");
      if (enum_thorough_simple.scientistsNameSpaceTestH(bell) != bell) throw new Exception("scientistsNameSpaceTest Global H failed");
      if (enum_thorough_simple.scientistsNameSpaceTestI(bell) != bell) throw new Exception("scientistsNameSpaceTest Global I failed");
      if (enum_thorough_simple.scientistsNameSpaceTestJ(bell) != bell) throw new Exception("scientistsNameSpaceTest Global J failed");
      if (enum_thorough_simple.scientistsNameSpaceTestK(bell) != bell) throw new Exception("scientistsNameSpaceTest Global K failed");
      if (enum_thorough_simple.scientistsNameSpaceTestL(bell) != bell) throw new Exception("scientistsNameSpaceTest Global L failed");
    }
    {
      int val = enum_thorough_simple.argh;
      if (enum_thorough_simple.renameTest1(val) != val) throw new Exception("renameTest Global 1 failed");
      if (enum_thorough_simple.renameTest2(val) != val) throw new Exception("renameTest Global 2 failed");
    }
    {
      NewNameStruct n = new NewNameStruct();
      if (n.renameTest1(NewNameStruct.bang) != NewNameStruct.bang) throw new Exception("renameTest 1 failed");
      if (n.renameTest2(NewNameStruct.bang) != NewNameStruct.bang) throw new Exception("renameTest 2 failed");
      if (n.renameTest3(NewNameStruct.simple1) != NewNameStruct.simple1) throw new Exception("renameTest 3 failed");
      if (n.renameTest4(NewNameStruct.doublename1) != NewNameStruct.doublename1) throw new Exception("renameTest 4 failed");
      if (n.renameTest5(NewNameStruct.doublename1) != NewNameStruct.doublename1) throw new Exception("renameTest 5 failed");
      if (n.renameTest6(NewNameStruct.singlename1) != NewNameStruct.singlename1) throw new Exception("renameTest 6 failed");
    }
    {
      if (enum_thorough_simple.renameTest3(NewNameStruct.bang) != NewNameStruct.bang) throw new Exception("renameTest Global 3 failed");
      if (enum_thorough_simple.renameTest4(NewNameStruct.simple1) != NewNameStruct.simple1) throw new Exception("renameTest Global 4 failed");
      if (enum_thorough_simple.renameTest5(NewNameStruct.doublename1) != NewNameStruct.doublename1) throw new Exception("renameTest Global 5 failed");
      if (enum_thorough_simple.renameTest6(NewNameStruct.doublename1) != NewNameStruct.doublename1) throw new Exception("renameTest Global 6 failed");
      if (enum_thorough_simple.renameTest7(NewNameStruct.singlename1) != NewNameStruct.singlename1) throw new Exception("renameTest Global 7 failed");
    }
    {
      TreesClass t = new TreesClass();
      int pine = TreesClass.pine;

      if (t.treesTest1(pine) != pine) throw new Exception("treesTest 1 failed");
      if (t.treesTest2(pine) != pine) throw new Exception("treesTest 2 failed");
      if (t.treesTest3(pine) != pine) throw new Exception("treesTest 3 failed");
      if (t.treesTest4(pine) != pine) throw new Exception("treesTest 4 failed");
      if (t.treesTest5(pine) != pine) throw new Exception("treesTest 5 failed");
      if (t.treesTest6(pine) != pine) throw new Exception("treesTest 6 failed");
      if (t.treesTest7(pine) != pine) throw new Exception("treesTest 7 failed");
      if (t.treesTest8(pine) != pine) throw new Exception("treesTest 8 failed");
      if (t.treesTest9(pine) != pine) throw new Exception("treesTest 9 failed");
      if (t.treesTestA(pine) != pine) throw new Exception("treesTest A failed");
      if (t.treesTestB(pine) != pine) throw new Exception("treesTest B failed");
      if (t.treesTestC(pine) != pine) throw new Exception("treesTest C failed");
      if (t.treesTestD(pine) != pine) throw new Exception("treesTest D failed");
      if (t.treesTestE(pine) != pine) throw new Exception("treesTest E failed");
      if (t.treesTestF(pine) != pine) throw new Exception("treesTest F failed");
      if (t.treesTestG(pine) != pine) throw new Exception("treesTest G failed");
      if (t.treesTestH(pine) != pine) throw new Exception("treesTest H failed");
      if (t.treesTestI(pine) != pine) throw new Exception("treesTest I failed");
      if (t.treesTestJ(pine) != pine) throw new Exception("treesTest J failed");
      if (t.treesTestK(pine) != pine) throw new Exception("treesTest K failed");
      if (t.treesTestL(pine) != pine) throw new Exception("treesTest L failed");
      if (t.treesTestM(pine) != pine) throw new Exception("treesTest M failed");
      if (t.treesTestN(pine) != pine) throw new Exception("treesTest N failed");
      if (t.treesTestO(pine) != pine) throw new Exception("treesTest O failed");

      if (enum_thorough_simple.treesTest1(pine) != pine) throw new Exception("treesTest Global 1 failed");
      if (enum_thorough_simple.treesTest2(pine) != pine) throw new Exception("treesTest Global 2 failed");
      if (enum_thorough_simple.treesTest3(pine) != pine) throw new Exception("treesTest Global 3 failed");
      if (enum_thorough_simple.treesTest4(pine) != pine) throw new Exception("treesTest Global 4 failed");
      if (enum_thorough_simple.treesTest5(pine) != pine) throw new Exception("treesTest Global 5 failed");
      if (enum_thorough_simple.treesTest6(pine) != pine) throw new Exception("treesTest Global 6 failed");
      if (enum_thorough_simple.treesTest7(pine) != pine) throw new Exception("treesTest Global 7 failed");
      if (enum_thorough_simple.treesTest8(pine) != pine) throw new Exception("treesTest Global 8 failed");
      if (enum_thorough_simple.treesTest9(pine) != pine) throw new Exception("treesTest Global 9 failed");
      if (enum_thorough_simple.treesTestA(pine) != pine) throw new Exception("treesTest Global A failed");
      if (enum_thorough_simple.treesTestB(pine) != pine) throw new Exception("treesTest Global B failed");
      if (enum_thorough_simple.treesTestC(pine) != pine) throw new Exception("treesTest Global C failed");
      if (enum_thorough_simple.treesTestD(pine) != pine) throw new Exception("treesTest Global D failed");
      if (enum_thorough_simple.treesTestE(pine) != pine) throw new Exception("treesTest Global E failed");
      if (enum_thorough_simple.treesTestF(pine) != pine) throw new Exception("treesTest Global F failed");
      if (enum_thorough_simple.treesTestG(pine) != pine) throw new Exception("treesTest Global G failed");
      if (enum_thorough_simple.treesTestH(pine) != pine) throw new Exception("treesTest Global H failed");
      if (enum_thorough_simple.treesTestI(pine) != pine) throw new Exception("treesTest Global I failed");
      if (enum_thorough_simple.treesTestJ(pine) != pine) throw new Exception("treesTest Global J failed");
      if (enum_thorough_simple.treesTestK(pine) != pine) throw new Exception("treesTest Global K failed");
      if (enum_thorough_simple.treesTestL(pine) != pine) throw new Exception("treesTest Global L failed");
      if (enum_thorough_simple.treesTestM(pine) != pine) throw new Exception("treesTest Global M failed");
//      if (enum_thorough_simple.treesTestN(pine) != pine) throw new Exception("treesTest Global N failed");
      if (enum_thorough_simple.treesTestO(pine) != pine) throw new Exception("treesTest Global O failed");
      if (enum_thorough_simple.treesTestP(pine) != pine) throw new Exception("treesTest Global P failed");
      if (enum_thorough_simple.treesTestQ(pine) != pine) throw new Exception("treesTest Global Q failed");
      if (enum_thorough_simple.treesTestR(pine) != pine) throw new Exception("treesTest Global R failed");
    }
    {
      HairStruct h = new HairStruct();
      int ginger = HairStruct.ginger;

      if (h.hairTest1(ginger) != ginger) throw new Exception("hairTest 1 failed");
      if (h.hairTest2(ginger) != ginger) throw new Exception("hairTest 2 failed");
      if (h.hairTest3(ginger) != ginger) throw new Exception("hairTest 3 failed");
      if (h.hairTest4(ginger) != ginger) throw new Exception("hairTest 4 failed");
      if (h.hairTest5(ginger) != ginger) throw new Exception("hairTest 5 failed");
      if (h.hairTest6(ginger) != ginger) throw new Exception("hairTest 6 failed");
      if (h.hairTest7(ginger) != ginger) throw new Exception("hairTest 7 failed");
      if (h.hairTest8(ginger) != ginger) throw new Exception("hairTest 8 failed");
      if (h.hairTest9(ginger) != ginger) throw new Exception("hairTest 9 failed");
      if (h.hairTestA(ginger) != ginger) throw new Exception("hairTest A failed");
      if (h.hairTestB(ginger) != ginger) throw new Exception("hairTest B failed");

      int red = enum_thorough_simple.red;
      if (h.colourTest1(red) != red) throw new Exception("colourTest HairStruct 1 failed");
      if (h.colourTest2(red) != red) throw new Exception("colourTest HairStruct 2 failed");
      if (h.namedanonTest1(enum_thorough_simple.NamedAnon2) != enum_thorough_simple.NamedAnon2) throw new Exception("namedanonTest HairStruct 1 failed");
      if (h.namedanonspaceTest1(enum_thorough_simple.NamedAnonSpace2) != enum_thorough_simple.NamedAnonSpace2) throw new Exception("namedanonspaceTest HairStruct 1 failed");

      int fir = TreesClass.fir;
      if (h.treesGlobalTest1(fir) != fir) throw new Exception("treesGlobalTest1 HairStruct 1 failed");
      if (h.treesGlobalTest2(fir) != fir) throw new Exception("treesGlobalTest1 HairStruct 2 failed");
      if (h.treesGlobalTest3(fir) != fir) throw new Exception("treesGlobalTest1 HairStruct 3 failed");
      if (h.treesGlobalTest4(fir) != fir) throw new Exception("treesGlobalTest1 HairStruct 4 failed");
    }
    {
      int blonde = HairStruct.blonde;
      if (enum_thorough_simple.hairTest1(blonde) != blonde) throw new Exception("hairTest Global 1 failed");
      if (enum_thorough_simple.hairTest2(blonde) != blonde) throw new Exception("hairTest Global 2 failed");
      if (enum_thorough_simple.hairTest3(blonde) != blonde) throw new Exception("hairTest Global 3 failed");
      if (enum_thorough_simple.hairTest4(blonde) != blonde) throw new Exception("hairTest Global 4 failed");
      if (enum_thorough_simple.hairTest5(blonde) != blonde) throw new Exception("hairTest Global 5 failed");
      if (enum_thorough_simple.hairTest6(blonde) != blonde) throw new Exception("hairTest Global 6 failed");
      if (enum_thorough_simple.hairTest7(blonde) != blonde) throw new Exception("hairTest Global 7 failed");
      if (enum_thorough_simple.hairTest8(blonde) != blonde) throw new Exception("hairTest Global 8 failed");
      if (enum_thorough_simple.hairTest9(blonde) != blonde) throw new Exception("hairTest Global 9 failed");
      if (enum_thorough_simple.hairTestA(blonde) != blonde) throw new Exception("hairTest Global A failed");

      if (enum_thorough_simple.hairTestA1(blonde) != blonde) throw new Exception("hairTest Global A1 failed");
      if (enum_thorough_simple.hairTestA2(blonde) != blonde) throw new Exception("hairTest Global A2 failed");
      if (enum_thorough_simple.hairTestA3(blonde) != blonde) throw new Exception("hairTest Global A3 failed");
      if (enum_thorough_simple.hairTestA4(blonde) != blonde) throw new Exception("hairTest Global A4 failed");
      if (enum_thorough_simple.hairTestA5(blonde) != blonde) throw new Exception("hairTest Global A5 failed");
      if (enum_thorough_simple.hairTestA6(blonde) != blonde) throw new Exception("hairTest Global A6 failed");
      if (enum_thorough_simple.hairTestA7(blonde) != blonde) throw new Exception("hairTest Global A7 failed");
      if (enum_thorough_simple.hairTestA8(blonde) != blonde) throw new Exception("hairTest Global A8 failed");
      if (enum_thorough_simple.hairTestA9(blonde) != blonde) throw new Exception("hairTest Global A9 failed");
      if (enum_thorough_simple.hairTestAA(blonde) != blonde) throw new Exception("hairTest Global AA failed");

      if (enum_thorough_simple.hairTestB1(blonde) != blonde) throw new Exception("hairTest Global B1 failed");
      if (enum_thorough_simple.hairTestB2(blonde) != blonde) throw new Exception("hairTest Global B2 failed");
      if (enum_thorough_simple.hairTestB3(blonde) != blonde) throw new Exception("hairTest Global B3 failed");
      if (enum_thorough_simple.hairTestB4(blonde) != blonde) throw new Exception("hairTest Global B4 failed");
      if (enum_thorough_simple.hairTestB5(blonde) != blonde) throw new Exception("hairTest Global B5 failed");
      if (enum_thorough_simple.hairTestB6(blonde) != blonde) throw new Exception("hairTest Global B6 failed");
      if (enum_thorough_simple.hairTestB7(blonde) != blonde) throw new Exception("hairTest Global B7 failed");
      if (enum_thorough_simple.hairTestB8(blonde) != blonde) throw new Exception("hairTest Global B8 failed");
      if (enum_thorough_simple.hairTestB9(blonde) != blonde) throw new Exception("hairTest Global B9 failed");
      if (enum_thorough_simple.hairTestBA(blonde) != blonde) throw new Exception("hairTest Global BA failed");

      if (enum_thorough_simple.hairTestC1(blonde) != blonde) throw new Exception("hairTest Global C1 failed");
      if (enum_thorough_simple.hairTestC2(blonde) != blonde) throw new Exception("hairTest Global C2 failed");
      if (enum_thorough_simple.hairTestC3(blonde) != blonde) throw new Exception("hairTest Global C3 failed");
      if (enum_thorough_simple.hairTestC4(blonde) != blonde) throw new Exception("hairTest Global C4 failed");
      if (enum_thorough_simple.hairTestC5(blonde) != blonde) throw new Exception("hairTest Global C5 failed");
      if (enum_thorough_simple.hairTestC6(blonde) != blonde) throw new Exception("hairTest Global C6 failed");
      if (enum_thorough_simple.hairTestC7(blonde) != blonde) throw new Exception("hairTest Global C7 failed");
      if (enum_thorough_simple.hairTestC8(blonde) != blonde) throw new Exception("hairTest Global C8 failed");
      if (enum_thorough_simple.hairTestC9(blonde) != blonde) throw new Exception("hairTest Global C9 failed");
      if (enum_thorough_simple.hairTestCA(blonde) != blonde) throw new Exception("hairTest Global CA failed");
    }
    {
      FirStruct f = new FirStruct();
      int blonde = HairStruct.blonde;

      if (f.hairTestFir1(blonde) != blonde) throw new Exception("hairTestFir 1 failed");
      if (f.hairTestFir2(blonde) != blonde) throw new Exception("hairTestFir 2 failed");
      if (f.hairTestFir3(blonde) != blonde) throw new Exception("hairTestFir 3 failed");
      if (f.hairTestFir4(blonde) != blonde) throw new Exception("hairTestFir 4 failed");
      if (f.hairTestFir5(blonde) != blonde) throw new Exception("hairTestFir 5 failed");
      if (f.hairTestFir6(blonde) != blonde) throw new Exception("hairTestFir 6 failed");
      if (f.hairTestFir7(blonde) != blonde) throw new Exception("hairTestFir 7 failed");
      if (f.hairTestFir8(blonde) != blonde) throw new Exception("hairTestFir 8 failed");
      if (f.hairTestFir9(blonde) != blonde) throw new Exception("hairTestFir 9 failed");
      if (f.hairTestFirA(blonde) != blonde) throw new Exception("hairTestFir A failed");
    }
    {
      enum_thorough_simple.GlobalInstance = enum_thorough_simple.globalinstance2;
      if (enum_thorough_simple.GlobalInstance != enum_thorough_simple.globalinstance2) throw new Exception("GlobalInstance 1 failed");

      Instances i = new Instances();
      i.MemberInstance = Instances.memberinstance3;
      if (i.MemberInstance != Instances.memberinstance3) throw new Exception("MemberInstance 1 failed");
    }
  }
}

