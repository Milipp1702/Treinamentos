﻿namespace Interface;
class Program
{
    static void Main(string[] args)
    {
        IPilha p = new Pilha();
        p.Empilha("xuxu1");
        p.Empilha("xuxu2");
        p.Empilha("xuxu3");
        p.Empilha("xuxu4");
        p.Empilha("xuxu5");
        Console.WriteLine($"A pilha tem {(p as Pilha).QtdElementos} elementos");
        Console.WriteLine($"O elemento {p.Topo} está no Topo da pilha");
        p.Desempilha();

        Console.WriteLine($"A pilha tem {(p as Pilha).QtdElementos} elementos");
        Console.WriteLine($"O elemento {p.Topo} está no Topo da pilha");
        p.Desempilha();

        Console.WriteLine($"A pilha tem {(p as Pilha).QtdElementos} elementos");
        Console.WriteLine($"O elemento {p.Topo} está no Topo da pilha");
        p.Desempilha();

        Console.WriteLine($"A pilha tem {(p as Pilha).QtdElementos} elementos");
        Console.WriteLine($"O elemento {p.Topo} está no Topo da pilha");
        p.Desempilha();

        Console.WriteLine($"A pilha tem {(p as Pilha).QtdElementos} elementos");
        Console.WriteLine($"O elemento {p.Topo} está no Topo da pilha");
        p.Desempilha();

        Console.WriteLine($"A pilha tem {(p as Pilha).QtdElementos} elementos");
        Console.WriteLine($"O elemento {p.Topo} está no Topo da pilha");
        p.Desempilha();

        IUmaCoisa iuc = new Pilha();
        iuc.metodo();
        IOutraCoisa ioc = new Pilha();
        ioc.metodo();
    }
}
