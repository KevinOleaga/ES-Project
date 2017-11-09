<%@ Page Title="Index" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ES.UI.Index" %>
<asp:Content ID="Menu" ContentPlaceHolderID="Menu" runat="server">
    <div class="sidebar" data-background-color="brown" data-active-color="danger">
        <div class="logo">
            <a href="Index.aspx" class="simple-text logo-normal">
                <img class="img-responsive custom_01 logo-normal" src="images/logo.png" />
            </a>
        </div>

        <div class="sidebar-wrapper">
            <div class="user">
                <div class="info">
                    <div class="photo">
                        <img src="images/profile.png" />
                    </div>

                    <a data-toggle="collapse" href="#users" class="collapsed">
                        <span>Perfil
                            <b class="caret"></b>
                        </span>
                    </a>

                    <div class="clearfix"></div>

                    <div class="collapse" id="users">
                        <ul class="nav">
                            <li>
                                <a href="MyProfile.aspx">
                                    <span class="sidebar-mini fa fa-user"></span>
                                    <span class="sidebar-normal">Mi Perfil</span>
                                </a>
                            </li>
                            <li>
                                <a href="UsersConfig.aspx">
                                    <span class="sidebar-mini fa fa-group"></span>
                                    <span class="sidebar-normal">Adm. Usuarios</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>

            <ul class="nav">
                <li>
                    <a href="Index.aspx">
                        <i class="fa fa-line-chart"></i>
                        <p>DASHBOARD</p>
                    </a>
                </li>
                <li>
                    <a data-toggle="collapse" href="#adm_alumnos">
                        <i class="fa fa-sliders"></i>
                        <p>
                            ADM. ALUMNOS
       					    <b class="caret"></b>
                        </p>
                    </a>
                    <div class="collapse" id="adm_alumnos">
                        <ul class="nav">
                            <li>
                                <a href="BuscarEstudiantes.aspx">
                                    <span class="sidebar-mini fa fa-search"></span>
                                    <span class="sidebar-normal">Buscar</span>
                                </a>
                            </li>
                            <li>
                                <a href="CrearEstudiante.aspx">
                                    <span class="sidebar-mini fa fa-plus"></span>
                                    <span class="sidebar-normal">Crear</span>
                                </a>
                            </li>
                            <li>
                                <a href="EditarEstudiante.aspx">
                                    <span class="sidebar-mini fa fa-pencil"></span>
                                    <span class="sidebar-normal">Editar</span>
                                </a>
                            </li>
                            <li>
                                <a href="EliminarEstudiante.aspx">
                                    <span class="sidebar-mini fa fa-trash-o"></span>
                                    <span class="sidebar-normal">Eliminar</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                 
                    <a data-toggle="collapse" href="#adm_encargados">
                        <i class="fa fa-sliders"></i>
                        <p>
                            ADM. ENCARGADOS
       					    <b class="caret"></b>
                        </p>
                    </a>
                       <li>
                     <div class="collapse" id="adm_encargados">
                        <ul class="nav">
                            <li>
                                <a href="BuscarEncargado.aspx">
                                    <span class="sidebar-mini fa fa-search"></span>
                                    <span class="sidebar-normal">Buscar</span>
                                </a>
                            </li>
                            <li>
                                <a href="InsertarEncargado.aspx">
                                    <span class="sidebar-mini fa fa-plus"></span>
                                    <span class="sidebar-normal">Crear</span>
                                </a>
                            </li>
                            <li>
                                <a href="EditarEncargado.aspx">
                                    <span class="sidebar-mini fa fa-pencil"></span>
                                    <span class="sidebar-normal">Editar</span>
                                </a>
                            </li>
                            <li>
                                <a href="EliminarEncargado.aspx">
                                    <span class="sidebar-mini fa fa-trash-o"></span>
                                    <span class="sidebar-normal">Eliminar</span>
                                </a>
                            </li>
                        </ul>
                    </div>


                </li>
                <li>
                    <a data-toggle="collapse" href="#adm_profesores">
                        <i class="fa fa-sliders"></i>
                        <p>
                            ADM. PROFESORES
       					    <b class="caret"></b>
                        </p>
                    </a>
                    <div class="collapse" id="adm_profesores">
                        <ul class="nav">
                            <li>
                                <a href="BuscarProfesor.aspx">
                                    <span class="sidebar-mini fa fa-search"></span>
                                    <span class="sidebar-normal">Buscar</span>
                                </a>
                            </li>
                            <li>
                                <a href="CrearProfesor.aspx">
                                    <span class="sidebar-mini fa fa-plus"></span>
                                    <span class="sidebar-normal">Crear</span>
                                </a>
                            </li>
                            <li>
                                <a href="EditarProfesor.aspx">
                                    <span class="sidebar-mini fa fa-pencil"></span>
                                    <span class="sidebar-normal">Editar</span>
                                </a>
                            </li>
                            <li>
                                <a href="EliminarProfesor.aspx">
                                    <span class="sidebar-mini fa fa-trash-o"></span>
                                    <span class="sidebar-normal">Eliminar</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                </li>
                <li>
                    <a data-toggle="collapse" href="#adm_grupos">
                        <i class="fa fa-sliders"></i>
                        <p>
                            ADM. GRUPOS
       					    <b class="caret"></b>
                        </p>
                    </a>
                    <div class="collapse" id="adm_grupos">
                        <ul class="nav">
                            <li>
                                <a href="BuscarGrupo.aspx">
                                    <span class="sidebar-mini fa fa-search"></span>
                                    <span class="sidebar-normal">Buscar</span>
                                </a>
                            </li>
                            <li>
                                <a href="CrearGrupo.aspx">
                                    <span class="sidebar-mini fa fa-plus"></span>
                                    <span class="sidebar-normal">Crear</span>
                                </a>
                            </li>
                            <li>
                                <a href="EditarGrupo.aspx">
                                    <span class="sidebar-mini fa fa-pencil"></span>
                                    <span class="sidebar-normal">Editar</span>
                                </a>
                            </li>
                            <li>
                                <a href="EliminarGrupo.aspx">
                                    <span class="sidebar-mini fa fa-trash-o"></span>
                                    <span class="sidebar-normal">Eliminar</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                </li>
                <li>
                    <a href="Herramientaas.aspx">
                        <i class="fa fa-wrench"></i>
                        <p>HERRAMIENTAS</p>
                    </a>
                </li>
            </ul>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Head" ContentPlaceHolderID="Head" runat="server">
    <nav class="navbar navbar-default">
        <div class="container-fluid">
            <div class="navbar-minimize">
                <button id="minimizeSidebar" class="btn btn-fill btn-icon"><i class="fa fa-bars"></i></button>
            </div>

            <div class="navbar-header">
                <button type="button" class="navbar-toggle">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar bar1"></span>
                    <span class="icon-bar bar2"></span>
                    <span class="icon-bar bar3"></span>
                </button>
                <a class="navbar-brand" href="#">
                    Dashboard
                </a>
            </div>

            <div class="collapse navbar-collapse">
                <ul class="nav navbar-nav navbar-right">
                    <li class="dropdown">
                        <a href="#notifications" class="dropdown-toggle" data-toggle="dropdown">
                            <i class="fa fa-sign-out fa fa-2x"></i>
                            <p class="hidden-md hidden-lg"><b class="caret"></b></p>
                        </a>
                        <ul class="dropdown-menu">
                            <li><a href="Login.aspx">Cerrar Sesión</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="Content" runat="server">
</asp:Content>
