using System;
using System.Linq;
using System.Collections.Generic;

namespace Wanichuka
{
    class Food
    {
        public int benefit_productivity = 0;
        public int benefit_damage = 0;

        public Food(int benefit_productivity, int benefit_damage)
        {
            this.benefit_productivity = benefit_productivity;
            this.benefit_damage = benefit_damage;
        }
    }
    class Creature
    {
        private string name { get; }
        private int productivity { get; }
        private int damage { get; }
        private int defense { get; }
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
            foods[index];
        }
    }

    class Program 
    {
        static void Main() 
        {
           
        }
    }
}
