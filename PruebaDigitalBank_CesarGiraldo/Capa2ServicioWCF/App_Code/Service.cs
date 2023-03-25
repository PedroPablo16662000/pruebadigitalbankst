using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
    protected IDataAcces _dataAcess = new DataAcces();
    public bool Agregar(UsuarioModel usuario)
    {
        try
        {
            return _dataAcess.AddUser(usuario);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public bool Modificar(UsuarioModel usuario)
    {
        try
        {
            return _dataAcess.ModifyUser(usuario);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public List<UsuarioModel> Consultar()
    {
        try
        {
            return _dataAcess.GetList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public bool Eliminar(int idusuario)
    {
        try
        {
            return _dataAcess.DeleteUser(idusuario);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
