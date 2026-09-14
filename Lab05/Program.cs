namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== >> GAME TITLE << ==");
            Console.WriteLine("Hero vs. Monster -- Caluclate Damage");

            // Hero Stats
            Console.Write("Hero HP: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            // Monster
            Console.Write("Monster Hp: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monHp);
            Console.Write("Monster Attack: ");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.Write("Monster Defense: ");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monDef);

            // Check for valid input
            bool heroInputValid = heroHpOk && heroAtkOk && heroDefOk;
            bool monsterInputValid = monHpOk && monAtkOk && monDefOk;
            Console.WriteLine($"Hero stats valid: {heroInputValid}");
            Console.WriteLine($"Monster stats valid: {monsterInputValid}");
            Console.WriteLine($"[HERO]    HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.WriteLine($"[MONSTER]    HP: {monHp}, ATK: {monAtk}, DEF: {monDef}");

            // Hero drinks potion before the fight (Compond assignment: += )
            int potionHeal = 14;
            // heroHp = HeroHp + potionHeal ผลคือ  114
            // heroHp += potionHeal ผลคือ 114 การคำนวณเหมือนกัน แต่เขียนสั้นกว่า
            heroHp += potionHeal; // Hero ดื่ม HP Potion
            Console.WriteLine($"Hero drinks a potion, healing {potionHeal} HP, Hero HP is: {heroHp}");

            int normalDamage = Math.Max(0, heroAtk - monDef); // โจมตีปกติ โดยการ -
            Console.WriteLine($"Normal attack deals: {normalDamage} DMG");

            int powerDamage = Math.Max(0, (heroAtk * 2) - monDef); //โจมตีพลัง โดยการคูณ
            Console.WriteLine($"Power attack deals: {powerDamage} DMG");

            int counterDamge = Math.Max(0, monAtk - heroDef); // Monster โจมตีกลับ ไม่ต้องเปลี่ยนสูตร เปลี่ยนแค่ตัวแปร
            Console.WriteLine($"Counter attack deals: {counterDamge} DMG");

            Random randomSomething = new Random();
            int roll = randomSomething.Next(1, 101); // สุ่ม 1 - 100 หรือค่าอื่นๆ ต้อง +1 เสมอ
            bool isCrit = roll <= 10; // โอกาสเลข 10 ตัวใน 100 คือ 10%
            int critDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage; // ได้ค่า 1 หรือ 0 เป็นตัวกำหนดว่าจะได้คริมั้ย
            Console.WriteLine($"Crit Damage roll: {roll} (Crit: {isCrit})");
            Console.WriteLine($"If critical, normal attack would deal: {critDamage} DMG");
        }
    }
}
