using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.DBConfiguration.EFCore
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureCreated();

            if (!context.MainMenus.Any())
            {
                IList<MainMenu> mainMenuItens = new List<MainMenu>(){
                        //Main-menu
                        new MainMenu() {/* MainMenuId = 1,*/ Area = "", Controller = "Home", Action = "Index",   Name = "Home",       NavIcon = "nav-icon fas fa-home",    TipoMenu = TipoMenu.MainMenu },
                        new MainMenu() { /*MainMenuId = 2,*/ Area = "", Controller = "Home", Action = "Contact", Name = "Contact",    NavIcon = "nav-icon fas fa-phone",   TipoMenu = TipoMenu.MainMenu },
                        new MainMenu() {/* MainMenuId = 3,*/ Area = "", Controller = "Home", Action = "About",   Name = "About",      NavIcon = "nav-icon fas fa-comment", TipoMenu = TipoMenu.MainMenu },
                        //Main-menu-sidebar-logo
                        new MainMenu() {/* MainMenuId = 4,*/ Area = "", Controller = "Home", Action = "Index", Name = "E-Commerce", NavIcon = "nav-icon fas fa-home", PathImagem = "/AdminLTEv3/dist/img/AdminLTELogo.png", TipoMenu = TipoMenu.MainMenuSidebarLogo},
                        //Main-menu-sidebar <Cadastros>
                        new MainMenu() { /*MainMenuId = 5,*/ Area = "", Controller = "Cadastrar", Action = "", Name = "Cadastros", NavIcon = "nav-icon fas fa-edit", TipoMenu = TipoMenu.MainMenuHasTreeview},
                        //Main-menu-sidebar-children
                        //new MainMenu() { MainMenuId =  6, MainMenuOwnerId = 5, Area = "", Controller = "Register",  Action = "Clientes",       Name = "Clientes",         /*href = "#",*/  NavIcon = "fas fa-user nav-icon",            TipoMenu = TipoMenu.MainMenuSidebar },
                        new MainMenu() { /*MainMenuId =  6,*/ MainMenuOwnerId = 5, Area = "", Controller = "Pesquisar",  Action = "Clientes",        Name = "Clientes",         /*href = "#",*/  NavIcon = "fas fa-user nav-icon",            TipoMenu = TipoMenu.MainMenuSidebar },
                        new MainMenu() { /*MainMenuId =  7,*/ MainMenuOwnerId = 5, Area = "", Controller = "Pesquisar",  Action = "Fornecedores",    Name = "Fornecedores",     /*href = "#",*/  NavIcon = "fas fa-user-tie nav-icon",        TipoMenu = TipoMenu.MainMenuSidebar },
                        new MainMenu() {/* MainMenuId =  8,*/ MainMenuOwnerId = 5, Area = "", Controller = "Pesquisar",  Action = "Convenios",       Name = "Convênios",        /*href = "#",*/  NavIcon = "fas fa-user-tag nav-icon",        TipoMenu = TipoMenu.MainMenuSidebar },
                        new MainMenu() { /*MainMenuId =  9,*/ MainMenuOwnerId = 5, Area = "", Controller = "Pesquisar",  Action = "Transportadoras", Name = "Transportadoras",  /*href = "#",*/  NavIcon = "fas fa-user-tag nav-icon",        TipoMenu = TipoMenu.MainMenuSidebar },
                        new MainMenu() { /*MainMenuId = 10,*/ MainMenuOwnerId = 5, Area = "", Controller = "Pesquisar",  Action = "Produtos",        Name = "Produtos",         /*href = "#",*/  NavIcon = "fas fa-shopping-basket nav-icon", TipoMenu = TipoMenu.MainMenuSidebar },
                        new MainMenu() { /*MainMenuId = 11,*/ MainMenuOwnerId = 5, Area = "", Controller = "Pesquisar",  Action = "Serviços",        Name = "Serviços",         /*href = "#",*/  NavIcon = "fab fa-servicestack nav-icon",    TipoMenu = TipoMenu.MainMenuSidebar },
                        //Main-menu-sidebar <Conrtrole de usuários>
                        new MainMenu() { /*MainMenuId = 12,*/ Area = "", Controller = "Cadastrar", Action = "", Name = "Conrtrole de usuários", NavIcon = "fas fa-cogs nav-icon", TipoMenu = TipoMenu.MainMenuHasTreeview},
                        //Main-menu-sidebar-children
                        new MainMenu() { /*MainMenuId = 13,*/ MainMenuOwnerId = 12, Area = "", Controller = "Cadastrar", Action = "", Name = "Usuários", href = "#", NavIcon = "fas fa-users nav-icon", TipoMenu = TipoMenu.MainMenuSidebar}
                };

                foreach (MainMenu mainMenuItem in mainMenuItens)
                {
                    context.MainMenus.Add(mainMenuItem);
                    context.SaveChanges();
                }                
            }
        }
    }
}
