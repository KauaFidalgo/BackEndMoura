using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Carro
    {
     // Atributos privados
    private string marca;
    private string modelo;
    private int velocidadeAtual;

    // Métodos para definir e obter a marca
    public void DefinirMarca(string valor)
    {
        marca = valor;
    }

    public string ObterMarca()
    {
        return marca;
    }

    // Métodos para definir e obter o modelo
    public void DefinirModelo(string valor)
    {
        modelo = valor;
    }

    public string ObterModelo()
    {
        return modelo;
    }

    // Obter velocidade
    public int ObterVelocidade()
    {
        return velocidadeAtual;
    }

    // Métodos para acelerar e frear
    public void Acelerar(int valor)
    {
        velocidadeAtual += valor;
    }

    public void Frear(int valor)
    {
        velocidadeAtual -= valor;

        if (velocidadeAtual < 0)
        {
            velocidadeAtual = 0;
        }
    } 
    }
}