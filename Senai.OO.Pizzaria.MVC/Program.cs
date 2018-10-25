﻿using System;
using Senai.OO.Pizzaria.MVC.ViewModels;
using Senai.OO.Pizzaria.MVC.Util;
using Senai.OO.Pizzaria.MVC.ViewsControllers;

namespace Senai.OO.Pizzaria.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0, opcaoLogado = 0;
            do
            {
                MenuUtil.MenuDeslogado();

                opcaoDeslogado = int.Parse(Console.ReadLine());

                switch (opcaoDeslogado)
                {
                    case 1:{
                        UsuarioViewController.CadastrarUsuario();
                        break;
                    }
                    case 3:{
                        UsuarioViewController.ListarUsuario();
                        break;
                    }
                    case 0:{
                        System.Console.WriteLine("Tchau");
                        break;
                    }
                    default:{
                        System.Console.WriteLine("Opção Inválida");
                        break;
                    }
                }
            }while(opcaoDeslogado != 0);
        }
    }
}
