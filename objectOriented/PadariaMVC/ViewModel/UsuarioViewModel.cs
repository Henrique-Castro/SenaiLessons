using System;

namespace PadariaMVC.ViewModel
{
    public class UsuarioViewModel : BaseViewModel
    {
        public string Email{get;set;}
        public string  Senha{get;set;}
        UsuarioViewModel[] ArrayUsuarios; 
    }
}