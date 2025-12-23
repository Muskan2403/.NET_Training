// See https://aka.ms/new-console-template for more information
using StudentMgmtSystem;

StudentBL sBLObj = new StudentBL();
sBLObj.AcceptStudentDetails();

// sBLObj.CalcTotal();

// sBLObj.CalcAvg();

// System.Console.WriteLine($"Total {sBLObj.CalcTotal()}");
// System.Console.WriteLine($"Percentage :{sBLObj.CalcAvg()}");
int t1;
float p1;
sBLObj.CalcResult(out t1, out p1);

System.Console.WriteLine($"Total {t1}");
System.Console.WriteLine($"Percentage :{p1}");

