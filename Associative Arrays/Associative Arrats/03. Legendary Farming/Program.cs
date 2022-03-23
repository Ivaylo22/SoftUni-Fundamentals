using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            {
                { "shards", 0 },
                { "motes", 0},
                { "fragments", 0}
            };
            
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();
            string itemObtained = string.Empty;

            while (string.IsNullOrEmpty(itemObtained))
            {
                string materialsLine = Console.ReadLine().ToLower();
                string[] materialsArr = materialsLine.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < materialsArr.Length; i += 2)
                {
                    string currentMaterial = materialsArr[i + 1];
                    int currentMaterialQuantity = int.Parse(materialsArr[i]);

                    if (keyMaterials.ContainsKey(currentMaterial)) 
                    {
                        keyMaterials[currentMaterial] += currentMaterialQuantity;

                        if (keyMaterials["shards"] >= 250)
                        {
                            itemObtained = "Shadowmourne";
                            keyMaterials["shards"] -= 250;
                            break;
                        }
                        if (keyMaterials["fragments"] >= 250)
                        {
                            itemObtained = "Valanyr";
                            keyMaterials["fragments"] -= 250;
                            break;
                        }
                        if (keyMaterials["motes"] >= 250)
                        {
                            itemObtained = "Dragonwrath";
                            keyMaterials["motes"] -= 250;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(currentMaterial))
                        {
                            junkMaterials[currentMaterial] = 0;
                        }
                        junkMaterials[currentMaterial] += currentMaterialQuantity;
                    }
                }

            }


            Console.WriteLine($"{itemObtained} obtained!");
            foreach (var keyMats in keyMaterials)
            {
                Console.WriteLine($"{keyMats.Key}: {keyMats.Value}");
            }
            foreach (var junkMats in junkMaterials)
            {
                Console.WriteLine($"{junkMats.Key}: {junkMats.Value}");
            }
        }
    }
}
