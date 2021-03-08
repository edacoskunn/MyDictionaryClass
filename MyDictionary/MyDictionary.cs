using System;
using System.Linq;

namespace MyDictionary
{
    class MyDictionary<K, V>
    {
        K[] Keys;
        V[] Values;

        public MyDictionary()
        {
            Keys = new K[0];
            Values = new V[0];
        }
        public void Add(K anahtar, V deger)
        {
            V[] Tempvalues = Values;
            K[] Tempkeys = Keys;
            Keys = new K[Keys.Length + 1];
            Values = new V[Values.Length + 1];
            for (int i = 0; i < Tempvalues.Length; i++)
            {
                Keys[i] = Tempkeys[i];
                Values[i] = Tempvalues[i];
            }
            Keys[Keys.Length - 1] = anahtar;
            Values[Keys.Length - 1] = deger;
        }
        public void List()
        {
            for (int i = 0; i < Keys.Length; i++)
            {
                Console.WriteLine("[" + Keys[i] + "," + Values[i] + "]");
            }
        }
        public int Count
        {
            get { return Keys.Length; }
        }
        public K[] OnlyGetKeys
        {
            get { return Keys; }
        }
        public V[] OnlyGetValues
        {
            get { return Values; }
        }
        public bool ContaninsKeys( K keys)
        {
            bool deger = true;
            if (Keys.Contains(keys)==true)
            {
                deger = true;
            }
            else
            {
                deger = false;
            }
            return deger;
        }
        public bool ContaninsValues(V values)
        {
            bool deger = true;
            if (Values.Contains(values) == true)
            {
                deger = true;
            }
            else
            {
                deger = false;
            }
            return deger;
        }
        public bool Remove(K keys)
        {
            bool deger = true;
            if (Keys.Contains(keys) == true)
            {
               int yenideger= Array.IndexOf(Keys, keys);
                Console.WriteLine("silindi");
                Array.Clear(Keys, yenideger,1);
                Array.Clear(Values, yenideger, 1);
                
                deger = true;
            }
            else
            {
                deger = false;
            }
            return deger;
        }
        public void Clear(K keys,int eleman)
        {
            int yenikeys = Convert.ToInt32(keys);
            Array.Clear(Keys, yenikeys, eleman);
            Array.Clear(Values, yenikeys, eleman);
        }
        public void KeysList()
        {
            Console.Write("[");
            for (int i = 0; i < Keys.Length - 1; i++)
            {
                Console.Write(Keys[i] + ",");
            }
            Console.WriteLine(Keys[Keys.Length - 1] + "]");
        }
        public void ValuesList()
        {
            Console.Write("[");
            for (int i = 0; i < Values.Length - 1; i++)
            {
                Console.Write(Values[i] + ",");
            }
            Console.WriteLine(Keys[Values.Length - 1] + "]");
        }
        public bool TryGetValue(K keys, out V value)
        {
            
            if (Keys.Contains(keys) == true)
            {
                int yenideger = Array.IndexOf(Keys, keys);
                value = Values[yenideger];
                Console.WriteLine(value);
                return true;
            }
            value = default(V);
                 return false;
        }  
        }
    }






