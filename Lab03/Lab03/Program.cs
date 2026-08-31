namespace Lab03
/*
Student ID : 1690701725
Name       : นายศุภฤกษ์ แก้วพระโอ๊ะ
Section    : 129B
No.        : N/A
Course     : GI113 Computer Programming (GI)*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // Boss Stats
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"NAME: {bossName}" +
                $"\nRANK: {rank}" +
                $"\nLEVEL: {level} / {MaxLevel}" +
                $"\nHP: {currentHp} / {maxHp}" +
                $"\nATTACK POWER: {attackPower}" +
                $"\nCRIT MULTIPLIER: {critMultiplier}" +
                $"\nIS BOSS: {isBoss}");

            // Implicit conversion HP (int) --> double
            Console.WriteLine("\n----- Implicit Conversation: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (double): {currentHpDouble}");


            // Calcuate Percent as bouble
            Console.WriteLine("\n----- Eaxact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");

            // Explicit casting attack power (float) ---> int
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int attackDisplay = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackDisplay}");

            // Cast vs. Convert: Crit Multiplier
            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");




        }
    }
}
