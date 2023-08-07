﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray.Logic
{
    public class Arreglos
    {
        private int[] _array;
        private int _top;

        public Arreglos(int n)
        {
            _array = new int[n];
            _top = 0;
            N = n;
        }

        public int N { get; }

        public bool IsFull => _top == N;
        public bool IsEmpty => _top == 0;

            public void Fill(int minimo, int maximo)
            {
            Random random = new Random();
            for (int contador = 0; contador < N; contador++)
            {
                _array[contador] = random.Next(minimo, maximo);             
            }
            _top = N;
            }
        //Números No Repetidos
        public Arreglos NotRepetidos()
        {
            int countNotRepet = 0;
            for(int i = 0; i < _top; i++)
            {
                bool isRepet = false;
                for (int j = 0; j < _top; j++)
                {
                    if(i != j && _array[i] == _array[j])
                    {
                            isRepet = true;
                            break;
                    }
                }
                if(!isRepet)
                {
                    countNotRepet++;
                }
            }
            var nonRepead = new Arreglos(countNotRepet);
            for (int i = 0; i < _top; i++)
            {
                bool isRepet = false;
                for (int j = 0; j < _top; j++)
                {
                    if (i != j)
                    {

                        if (_array[i] == _array[j])
                        {
                            isRepet = true;
                            break;
                        }
                    }
                }
                if (!isRepet)
                {
                    nonRepead.Add(_array[i]);
                }
            }
            return nonRepead;
        }

        //Números Repetidos
        public Arreglos Repetidos()
        {
            int countRepetido = 0;
            for(int i =0; i <= _top; i++)
            {
                bool isRepetido = false;
                for (int j = 0; j < _top; j++)
                {
                    if(i == j && _array[i] == _array[j])
                    {
                        isRepetido = true;
                        break;
                    }
                }
                if(isRepetido)
                {
                    countRepetido++;
                }
            }
            var siRepetidos = new Arreglos(countRepetido);
            for (int i=0; i< _top; i++)
            {
                bool isRepetido = false;
                for (int j = 0; j < _top; j++)
                {
                    if(i != j)
                    {
                        if (_array[i] == _array[j])
                        {
                            isRepetido = true;
                            break;
                        }
                    }
                }
                if(isRepetido)
                {
                    siRepetidos.Add(_array[i]);
                }
            }
            return siRepetidos;
        }
        //Números Primos 
        public Arreglos Primo() 
        {
            int countPrimos = 0;
            for (int i = 0; i < _top; i ++ )
            {
                if (IsPrimo(_array[i]))
                {
                    countPrimos++;
                }
            }
            var getIsPrimo = new Arreglos(countPrimos);

            for (int i = 0; i < _top; i++)
            {
                if (IsPrimo(_array[i]))
                {
                    getIsPrimo.Add(_array[i]);
                }
            }
            return getIsPrimo;
        }

        

        //Números  Pares
        public Arreglos Pares()
        {
            int countPares = 0;
            for (int i = 0; i < _top; i++)
            {
                if (_array[i] % 2 == 0)
                {
                    countPares++;
                }
            }
                
            var getPares = new Arreglos(countPares);
            for (int i = 0; i < _top; i++)
            {
                if (_array[i] % 2 == 0)
                {
                    getPares.Add(_array[i]);
                }
            }
            return getPares;
        }

        //sort(true) forma descendente
        public void Sort()
        {
            Sort(false);
        }

        //Ordenamiento Método de la burbuja
        public void Sort(bool desc)
        {
            for (int i = 0; i < _top -1; i++)
            {
                for (int j = i + 1; j < _top; j++)
                {
                    if(desc)
                    {
                        if (_array[i] < _array[j])
                        {
                            Change(ref _array[i], ref _array[j]);
                        }
                    }
                    else
                    {
                        if (_array[i] > _array[j])
                        {
                            Change(ref _array[i], ref _array[j]);
                        }
                    }
                    
                }
            }
        }

        public void Add(int n)
        {
            if (IsFull)
            {
                throw new Exception("This array is full");
            }
            _array[_top] = n;
            _top++;
        }

        public void Insert(int position, int number)
        {
            if (IsFull)
            {
                throw new Exception("This array is full");
            }
            if (position < 0) position = 0;
            
            if (position > _top) position = _top;
           
            for (int i = _top; i > position; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[position] = number;
            _top++;
        }

        public override string ToString()
            {
            string output = string.Empty;
            int count = 0;
            for (int i=0; i<_top; i++)
            {
                    if (count >9)
                    {
                        output += "\n";
                        count = 0;
                    }
                    output += $"{_array[i]}\t";
                    count++;
            }
            return output;
            }

        private void Change( ref int a, ref int b)
        {
            var aux = a;
            a = b;
            b = aux;
        }

        private bool IsPrimo(int n)
        {
            if (n == 1) return false;
            for (int i = 2; i <= Math.Sqrt(n) ; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
                
            }
            return true;
        }
        

    }
}
