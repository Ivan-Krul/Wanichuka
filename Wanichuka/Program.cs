using System;
using System.Linq;
using System.Collections.Generic;

namespace Wanichuka
{
    class Food
    {
        public string name;
        public int benefit_productivity = 0;
        public int benefit_damage = 0;

        public Food(string name,int benefit_productivity, int benefit_damage)
        {
            this.name = name;
            this.benefit_productivity = benefit_productivity;
            this.benefit_damage = benefit_damage;
        }
    }
    class Creature
    {
        public string name;
        public int productivity;
        public int damage;
        public int defense;
        public List<Food> foods;

        public Creature(string name,int productivity,int damage,int defense) {
            this.name = name;
            this.productivity = productivity;
            this.damage = damage;
            this.defense = defense;
        }

        public void AddFood(Food food)
        {
            foods.Add(food);
        }
        public void UseFood(int index)
        {
            productivity += foods[index].benefit_productivity;
            damage += foods[index].benefit_damage;
        }
        public void Info()
        {
            Console.Write("ATT - "+damage+'\n'+ "DEF - " + defense);
        }
        public void Hit(Creature who)
        {
            who.productivity -= (productivity * damage/2)-who.defense;
        }
    }

    class Program 
    {
        static void Main() 
        {
            Creature A=new Creature("Kris",100,5,5);
            Creature B = new Creature("Frisk", 50, 7, 8);
            Food a = new Food("Sandwich", 500, 500);
            A.foods.Add(a);
            a = new Food("Banana", 50, 0);
            A.foods.Add(a);
            a = new Food("Candy", 10, 100);
            B.foods.Add(a);
            a = new Food("Glove", 0, 200);
            B.foods.Add(a);

            bool is_two = false;

            Random random = new Random();

            while (A.productivity>0&&B.productivity>0)
            {
                int choice;
                Console.WriteLine(A.name + '\t' + A.productivity + "\t\t" + B.name + '\t' + B.productivity);
                choice = Convert.ToInt32(Console.Read());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine(A.name +" is hitted "+B.name);
                        A.Hit(B);
                        break;
                    case 1:
                        B.Info();
                        break;
                    case 2:
                        A.Info();
                        break;
                    case 3:
                        choice = Convert.ToInt32(Console.Read());
                        if (choice >= 0 && choice < A.foods.Count()) {
                            Console.WriteLine(A.name + " use a "+ A.foods[choice].name);
                            A.UseFood(choice); 
                        }
                        break;
                }

                if (is_two) {
                    Console.WriteLine(A.name + '\t' + A.productivity + "\t\t" + B.name + '\t' + B.productivity);
                    choice = Convert.ToInt32(Console.Read());
                }
                else
                {
                    choice = random.Next() % 4;
                }
                switch (choice)
                {
                    case 0:
                        Console.WriteLine(B.name + " is hitted " + A.name);
                        B.Hit(A);
                        break;
                    case 1:
                        A.Info();
                        break;
                    case 2:
                        B.Info();
                        break;
                    case 3:
                        choice = random.Next()% B.foods.Count();
                        if (choice >= 0 && choice < B.foods.Count())
                        {
                            Console.WriteLine(B.name + " use a " + B.foods[choice].name);
                            B.UseFood(choice);
                        }
                        break;
                }
            }
        }
    }
}
