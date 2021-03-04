using System;
using System.Text;

namespace Delegat {
   internal class Program {
      private delegate int StudentsComparator(Student student1, Student student2);

      private static void Sort(Student[] students, int currentLength, StudentsComparator comparator) {
         for (var i = 0; i < currentLength - 1; i++){
            for (var j = 0; j < currentLength - i - 1; j++){
               if (comparator(students[j], students[j + 1]) > 0){
                  var temp = students[j];
                  students[j] = students[j + 1];
                  students[j + 1] = temp;
               }
            }
         }
      }


      public static void Main(string[] args) {
         Console.OutputEncoding = Encoding.UTF8;
         var students = new Student[10];
         var index = 0;
         var isLoop = true;
         while (isLoop){
            Console.WriteLine("\nKonzolové menu:\n"
                              + "1 -> Načtení studentů z klávesnice\n"
                              + "2 -> Výpis studentů na obrazovku\n"
                              + "3 -> Seřazení studentů podle čísla\n"
                              + "4 -> Seřazení studentů podle jména\n"
                              + "5 -> Seřazení studentů podle fakulty\n"
                              + "0 -> Konec programu\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (choice){
               case 1:
                  Console.WriteLine("Enter name: ");
                  var name = Console.ReadLine();
                  Console.WriteLine("Enter number: ");
                  var number = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter faculty's name: ");
                  var faculty = Console.ReadLine();
                  students[index++] = new Student() {
                     Name = name, Number = number, Faculty = (Faculty) Enum.Parse(typeof(Faculty), faculty)
                  };
                  break;
               case 2:
                  for (int i = 0; i < index; i++){
                     Console.WriteLine(students[i]);
                  }

                  break;
               case 3:
                  Sort(students, index, (student1, student2) => student1.Number - student2.Number);
                  break;
               case 4:
                  Sort(students, index, (student1, student2) => student1.Name.CompareTo(student2.Name));
                  break;
               case 5:
                  Sort(students, index, (student1, student2) => student1.Faculty - student2.Faculty);
                  break;
               case 0:
                  isLoop = false;
                  break;
               default:
                  Console.WriteLine("Unknown command.");
                  break;
            }
         }
      }
   }
}