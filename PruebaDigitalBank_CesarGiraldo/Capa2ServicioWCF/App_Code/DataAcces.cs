using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Descripción breve de DataAcces
/// </summary>
public class DataAcces : IDataAcces
{
    string _connectionString = string.Empty;
    public DataAcces()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["UsuariosDB"].ConnectionString.ToString();
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public bool AddUser(UsuarioModel usuario)
    {
        bool result = false;
        using (SqlConnection cn = new SqlConnection(_connectionString))
        {
            SqlCommand cmd = new SqlCommand("CRUD_Usuario", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter("nombreUsuario", usuario.nombreUsuario);
            SqlParameter parameter2 = new SqlParameter("fechaNacimientoUsuario", usuario.fechaNacimientoUsuario);
            SqlParameter parameter3 = new SqlParameter("sexoUsuario", usuario.SexoUsuario);
            SqlParameter parameter4 = new SqlParameter("operacion", "C");
            SqlParameter[] parameters = new SqlParameter[] { parameter1, parameter2, parameter3, parameter4 };
            cmd.Parameters.AddRange(parameters);
            cn.Open();
            result = cmd.ExecuteScalar().ToString() == "1";
            cn.Close();
        }
        return result;
    }

    public bool DeleteUser(int idusuario)
    {
        bool result = false;
        using (SqlConnection cn = new SqlConnection(_connectionString))
        {
            SqlCommand cmd = new SqlCommand("CRUD_Usuario", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter parameter0 = new SqlParameter("idUsuario", idusuario);
            SqlParameter parameter4 = new SqlParameter("operacion", "D");
            SqlParameter[] parameters = new SqlParameter[] { parameter0, parameter4 };
            cmd.Parameters.AddRange(parameters);
            cn.Open();
            result = cmd.ExecuteScalar().ToString() == "1";
            cn.Close();
        }
        return result;
    }

    public List<UsuarioModel> GetList()
    {
        var result = new List<UsuarioModel>();
        using (SqlConnection cn = new SqlConnection(_connectionString))
        {
            SqlCommand cmd = new SqlCommand("CRUD_Usuario", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter parameter4 = new SqlParameter("operacion", "R");
            SqlParameter[] parameters = new SqlParameter[] { parameter4 };
            cmd.Parameters.AddRange(parameters);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    result.Add(new UsuarioModel
                    {
                        idUsuario = int.Parse(dr["idUsuario"].ToString()),
                        nombreUsuario = dr["nombreUsuario"].ToString(),
                        fechaNacimientoUsuario = DateTime.Parse(dr["fechaNacimientoUsuario"].ToString()),
                        SexoUsuario = dr["sexoUsuario"].ToString()
                    });
                }
            }
            cn.Close();
        }
        return result;
    }

    public bool ModifyUser(UsuarioModel usuario)
    {
        bool result = false;
        using (SqlConnection cn = new SqlConnection(_connectionString))
        {
            SqlCommand cmd = new SqlCommand("CRUD_Usuario", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter parameter0 = new SqlParameter("idUsuario", usuario.idUsuario);
            SqlParameter parameter1 = new SqlParameter("nombreUsuario", usuario.nombreUsuario);
            SqlParameter parameter2 = new SqlParameter("fechaNacimientoUsuario", usuario.fechaNacimientoUsuario);
            SqlParameter parameter3 = new SqlParameter("sexoUsuario", usuario.SexoUsuario);
            SqlParameter parameter4 = new SqlParameter("operacion", "U");
            SqlParameter[] parameters = new SqlParameter[] {parameter0, parameter1, parameter2, parameter3, parameter4 };
            cmd.Parameters.AddRange(parameters);
            cn.Open();
            result = cmd.ExecuteScalar().ToString() == "1";
            cn.Close();
        }
        return result;
    }
}