using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de IDataAcces
/// </summary>
public interface IDataAcces
{
    bool AddUser(UsuarioModel usario);
    bool DeleteUser(int idusuario);
    List<UsuarioModel> GetList();
    bool ModifyUser(UsuarioModel usuario);
}