// See https://aka.ms/new-console-template for more information
using labAvgWeight;

Student student1 = new Student();
student1.name = "Worachot Thonglert";
student1.weight = 84.8f;

Student student2 = new Student();
student2.name = "Worachit Thonglert";
student2.weight = 82.5f;

Student student3 = new Student();
student3.name = "Pathipat Mattra";
student3.weight = 60.0f;

Student student4 = new Student();
student4.name = "Thanachok Suwan";
student4.weight = 75.0f;

Student student5 = new Student();
student5.name = "Naphat Suyoungkul";
student5.weight = 140.0f;

float avgWeight = (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight) / 5;
Console.WriteLine("Weight avg of Student : " + avgWeight);
Console.WriteLine("Weight max of Student : Naphat Suyoungkul");
Console.WriteLine("Weight min of Student : Pathipat Mattra");
Console.WriteLine("Name : Worachot Thonglert  ID : 653450299-0");