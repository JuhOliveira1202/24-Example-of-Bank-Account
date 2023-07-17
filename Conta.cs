using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício
{
    internal class Conta
    {
        //ATRIBUTOS

        private string titular;
        private double saldo;
        private int estado;

        //CONSTRUTORES

        public Conta() //C. VAZIO
        {
            titular = " Juliana Oliveira ";
            saldo = 100;
            estado = 1;
        }

        public Conta(string t, double s, int e) //C. PARÂMETROS
        {
            titular = t;
            saldo = s;
            estado = e;
        }

        public Conta(Conta c) //C. CÓPIA 
        {
            titular = c.getTitular();
            saldo = c.getSaldo();
            estado = c.getEstado();
        }

        //SELETORES

        public string getTitular()
        {
            return titular;
        }

        public double getSaldo()
        {
            return saldo;
        }

        public int getEstado()
        {
            return estado;
        }

        public string getEstadoExt()
        {
            if (estado == 1)
            {
                return "Conta ativa";
            }
            else if (estado == 2)
            {
                return "Conta fechada";
            }
            else
            {
                return "Conta bloqueada";
            }
        }



        //MODIFICADORES

        public void setTitular(string t)
        {
            if(t != "" && t != null)
            {
                titular = t;
            }
        }

        public void setEstado(int e)
        {
            if(e >= 1 && e <= 3)
            {
                estado = e;
            }

        }

        public bool depositar(double valor)
        {
            if (valor < 0)
            {
                saldo += valor;
                return true;
            }
            return false;
        }

        public bool levantar(double valor)
        {
            if(saldo >= valor && estado == 1)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }

        public bool transf(double v, Conta c) 
        {
            if (levantar(v) && c.getEstado() == 1)
            {
                c.depositar(v);
                return true;
            }
            return false;
        }

        //COMPORTAMENTO

        public override string ToString()
        {
            return "Titular: " + titular + "\n" + "Saldo: " + saldo + "\n" + "Estado: " + getEstadoExt();

        }
    }
}
