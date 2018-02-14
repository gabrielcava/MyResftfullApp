using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyResftfullApp.Daos.Interfaces;
using MyResftfullApp.Services;

namespace MyResftfullApp.Tests.Services
{
    [TestClass]
    public class UsuarioServiceTest
    {
        [TestMethod]
        public void UsuarioService_CreateUsuario_AllParameters_Succeeds()
        {
            //Arrange
            var usuario = new Usuario();
            var usuarioDaoMock = new Mock<IUsuarioDao>();
            usuarioDaoMock.Setup(x => x.Create(usuario)).Verifiable();

            var usuarioSerice = new UsuarioService(usuarioDaoMock.Object);

            //Act
            usuarioSerice.CreateUsuario(usuario);

            //Assert
            usuarioDaoMock.VerifyAll();

        }

        [TestMethod]
        public void UsuarioService_GetAllUsuarios_AllParameters_Succeeds()
        {
            //Arrange
            var usuario = new Usuario();
            var usuarioDaoMock = new Mock<IUsuarioDao>();
            usuarioDaoMock.Setup(x => x.GetAll()).Verifiable();

            var usuarioSerice = new UsuarioService(usuarioDaoMock.Object);

            //Act
            usuarioSerice.GetAllUsuarios();

            //Assert
            usuarioDaoMock.VerifyAll();
        }

        [TestMethod]
        public void UsuarioService_UpdateUsuario_AllParameters_Succeeds()
        {
            //Arrange
            var usuario = new Usuario()
            {
                Id = 1
            };
            var usuarioDaoMock = new Mock<IUsuarioDao>();
            usuarioDaoMock.Setup(x => x.Update(usuario.Id, usuario)).Verifiable();

            var usuarioSerice = new UsuarioService(usuarioDaoMock.Object);

            //Act
            usuarioSerice.UpdateUsuario(usuario.Id, usuario);

            //Assert
            usuarioDaoMock.VerifyAll();
        }

        [TestMethod]
        public void UsuarioService_DeleteUsuario_AllParameters_Succeeds()
        {
            //Arrange
            var usuario = new Usuario()
            {
                Id = 1
            };
            var usuarioDaoMock = new Mock<IUsuarioDao>();
            usuarioDaoMock.Setup(x => x.Delete(usuario.Id)).Verifiable();

            var usuarioSerice = new UsuarioService(usuarioDaoMock.Object);

            //Act
            usuarioSerice.DeleteUsuario(usuario.Id);

            //Assert
            usuarioDaoMock.VerifyAll();
        }
    }
}
