/*
 
Student ID : 1690701725
Name       : นายศุภฤกษ์ แก้วพระโอ๊ะ
Section    : 129B
No.        : 30
Course     : GI113 Computer Programming (GI)*/
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int lives = 0; // ตัวแปรหลักเพื่อเช็ค

            //if (lives <= 0) // ในวงเล็บคือเงื่อนไขที่จะต้องเป็นจริงๆ
            //{
            //    // บล็อคของโค๊ดที่จะทำงาน เมื่อเงื่อนไขเป็นจริง
            //    Console.WriteLine("Game Over");
            //}
            //else
            //{
            //    Console.WriteLine("Continue to play!");
            //}

            //// เมื่อเงื่อนไขทำงานเสร็จแล้ว หรือ เงื่อนไขไม่ตรงเลยโค๊ดทำงานต่อ
            //Console.WriteLine("Continue to run");

            //int level = 3;

            //bool isPoisioned = false;
            //if (isPoisioned) { } // ได้เท็จเพราะ isPoisioned = false
            //if (!isPoisioned) { } // ได้จริงเพราะ isPoisioned = false


            //bool hasKey = true; //มีกุญแจ true/false
            //Console.WriteLine("Your level (1-99): ");
            //bool ok = int.TryParse(Console.ReadLine(), out int level);

            //if (!ok || level < 1 || level > 99)
            //{
            //    Console.WriteLine("Invalid level.");
            //}
            //else if (level >= 10 && hasKey) // && และ กับ || หรือ
            //{
            //    Console.WriteLine("Boss floor unlocked.");
            //}
            //else if (level >= 5) // ต้องมีเลเวล 5 ขึิ้น
            //{
            //    if (hasKey == true) // และต้องมีกุญแจ กุญแจเป็นจริง
            //    {
            //        Console.WriteLine("The door opens.");
            //    }
            //    else // กุญแจเป็นเท็จ ไม่มีกุญแจ
            //    {
            //        Console.WriteLine("Locked. Find a key");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The door stays shut.");
            //}
            int heroHp = 100;
            int heroStm = 100;
            int monHp = 150;
            int heroAtk = 50;
            int potionHeal = 50;
            int potionStamina = 50;

            Console.WriteLine("GAME TITLE: HAMOV's Fight");
            Console.WriteLine("HERO HAMOV ENCOUNTER A MONSTER...");
            Console.WriteLine("ACTION 1: ATTACK");
            Console.WriteLine("ACTION 2: DRINK HP POTION");
            Console.WriteLine("ACTION 3: DRINK STM POTION");

            Console.WriteLine("CHOOSE YOUR ACTION (1-3)");
            bool isInputValid = int.TryParse(Console.ReadLine(), out int choice);

            if (isInputValid == false || choice < 1 || choice > 3) // เช็คเมื่อผู้เล่นใส่ input ผิด
            {
                Console.WriteLine("Invalid Input, Please enter action between 1,2 and 3"); // แจ้งว่าใส่ให้ถูกยังไง
            }
            else if (choice == 1) // เลือก action 1
            {
                monHp -= heroAtk; // hero โจมตี mon
                if (monHp <= 0)
                {
                    Console.WriteLine($"Hamov attacked the monster!!! with {heroAtk} DMG, Monster is defeated!!"); // ถ้าชีวิตมอนเหลือ 0
                }
                else if (monHp > 0)
                {
                    Console.WriteLine($"Hamov attacked the monster!!! with {heroAtk} DMG, Monster now have {monHp} HP left!"); // ถ้ามอนมีเลือดอยู่
                }
              
            }
            else if (choice == 2) // เลือก action 2
            {
                heroHp += potionHeal; // บวกเลือดจากค่าของ potionHp
                Console.WriteLine($"Hamov drank a potionHP, Hero HP is now {heroHp} Points"); // เลือดปัจจุบันของผู้เล่น
            }
            else if (choice == 3) // เลือก action 3
            {
                heroStm += potionStamina; // บวกสเตมิน่าจากค่าของ potionStm
                Console.WriteLine($"Hamov drank a potionStamina, Hero Stamina is now {heroStm} Points"); // สเตมิน่าปัจจุบัน
            }
        }
    }
}
