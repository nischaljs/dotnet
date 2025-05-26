using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace microsoftefcore.Models;

public partial class LoginSystemContext : DbContext
{
    public LoginSystemContext()
    {
    }

    public LoginSystemContext(DbContextOptions<LoginSystemContext> options)
        : base(options)
    {
    }
import { logDevResponse } from "../utils/logger";



const authService = {

  login: async (username, password) => {

    try {

      const response = await axios.post(`${import.meta.env.VITE_BASE_API_URL}/auth/login`,

        { UserName: username, Password: password }

      );

      logDevResponse('login', response?.data);

      if (response?.data?.Token) {

        localStorage.setItem('token', response?.data?.Token);

        localStorage.setItem('displayName', response?.data?.DisplayName);

        localStorage.setItem('expiration', response?.data?.Expiration);

      }

      return response?.data;

    } catch (error) {

      throw error;

    }

  },



  logout: () => {

    localStorage.removeItem('token');

  },



  getCurrentUser: async () => {

    const token = localStorage.getItem('token');

    const name = localStorage.getItem('displayName');

    if (token) {

      try {

        const response = await api.get('/Person/GetMyRoles');

        logDevResponse('getCurrentUser/GetMyRoles', response?.data);

        const roles = response?.data || [];

        return {

          isAuthenticated: true,

          token,

          name,

          role: roles[0] || null,

          roles: roles,

        };

      } catch (error) {

        console.error('Error fetching roles:', error);

        return { isAuthenticated: false };

      }

    }

    return { isAuthenticated: false };

  },



  forgotPassword: async (email) => {

    try {

      const response = await axios.post(`${import.meta.env.VITE_BASE_API_URL}/auth/ForgotPassword`, { EmailAddress

        : email });

      logDevResponse('forgotPassword', response?.data);

      return response?.data;

    } catch (error) {

      throw error;

    }

  }





};



export default authService;
    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<Student> Students { get; set; }
import { logDevResponse } from "../utils/logger";



const authService = {

  login: async (username, password) => {

    try {

      const response = await axios.post(`${import.meta.env.VITE_BASE_API_URL}/auth/login`,

        { UserName: username, Password: password }

      );

      logDevResponse('login', response?.data);

      if (response?.data?.Token) {

        localStorage.setItem('token', response?.data?.Token);

        localStorage.setItem('displayName', response?.data?.DisplayName);

        localStorage.setItem('expiration', response?.data?.Expiration);

      }

      return response?.data;

    } catch (error) {

      throw error;

    }

  },



  logout: () => {

    localStorage.removeItem('token');

  },



  getCurrentUser: async () => {

    const token = localStorage.getItem('token');

    const name = localStorage.getItem('displayName');

    if (token) {

      try {

        const response = await api.get('/Person/GetMyRoles');

        logDevResponse('getCurrentUser/GetMyRoles', response?.data);

        const roles = response?.data || [];

        return {

          isAuthenticated: true,

          token,

          name,

          role: roles[0] || null,

          roles: roles,

        };

      } catch (error) {

        console.error('Error fetching roles:', error);

        return { isAuthenticated: false };

      }

    }

    return { isAuthenticated: false };

  },



  forgotPassword: async (email) => {

    try {

      const response = await axios.post(`${import.meta.env.VITE_BASE_API_URL}/auth/ForgotPassword`, { EmailAddress

        : email });

      logDevResponse('forgotPassword', response?.data);

      return response?.data;

    } catch (error) {

      throw error;

    }

  }





};



export default authService;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=LoginSystem;user=root;sslmode=None", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.32-mariadb"));
import { logDevResponse } from "../utils/logger";



const authService = {

  login: async (username, password) => {

    try {

      const response = await axios.post(`${import.meta.env.VITE_BASE_API_URL}/auth/login`,

        { UserName: username, Password: password }

      );

      logDevResponse('login', response?.data);

      if (response?.data?.Token) {

        localStorage.setItem('token', response?.data?.Token);

        localStorage.setItem('displayName', response?.data?.DisplayName);

        localStorage.setItem('expiration', response?.data?.Expiration);

      }

      return response?.data;

    } catch (error) {

      throw error;

    }

  },



  logout: () => {

    localStorage.removeItem('token');

  },



  getCurrentUser: async () => {

    const token = localStorage.getItem('token');

    const name = localStorage.getItem('displayName');

    if (token) {

      try {

        const response = await api.get('/Person/GetMyRoles');

        logDevResponse('getCurrentUser/GetMyRoles', response?.data);

        const roles = response?.data || [];

        return {

          isAuthenticated: true,

          token,

          name,

          role: roles[0] || null,

          roles: roles,

        };

      } catch (error) {

        console.error('Error fetching roles:', error);

        return { isAuthenticated: false };

      }

    }

    return { isAuthenticated: false };

  },



  forgotPassword: async (email) => {

    try {

      const response = await axios.post(`${import.meta.env.VITE_BASE_API_URL}/auth/ForgotPassword`, { EmailAddress

        : email });

      logDevResponse('forgotPassword', response?.data);

      return response?.data;

    } catch (error) {

      throw error;

    }

  }





};



export default authService;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
      import { logDevResponse } from "../utils/logger";



const authService = {

  login: async (username, password) => {

    try {

      const response = await axios.post(`${import.meta.env.VITE_BASE_API_URL}/auth/login`,

        { UserName: username, Password: password }

      );

      logDevResponse('login', response?.data);

      if (response?.data?.Token) {

        localStorage.setItem('token', response?.data?.Token);

        localStorage.setItem('displayName', response?.data?.DisplayName);

        localStorage.setItem('expiration', response?.data?.Expiration);

      }

      return response?.data;

    } catch (error) {

      throw error;

    }

  },



  logout: () => {

    localStorage.removeItem('token');

  },



  getCurrentUser: async () => {

    const token = localStorage.getItem('token');

    const name = localStorage.getItem('displayName');

    if (token) {

      try {

        const response = await api.get('/Person/GetMyRoles');

        logDevResponse('getCurrentUser/GetMyRoles', response?.data);

        const roles = response?.data || [];

        return {

          isAuthenticated: true,

          token,

          name,

          role: roles[0] || null,

          roles: roles,

        };

      } catch (error) {

        console.error('Error fetching roles:', error);

        return { isAuthenticated: false };

      }

    }

    return { isAuthenticated: false };

  },



  forgotPassword: async (email) => {

    try {

      const response = await axios.post(`${import.meta.env.VITE_BASE_API_URL}/auth/ForgotPassword`, { EmailAddress

        : email });

      logDevResponse('forgotPassword', response?.data);

      return response?.data;

    } catch (error) {

      throw error;

    }

  }





};



export default authService;      .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Login>(entity =>
      import { logDevResponse } from "../utils/logger";



const authService = {

  login: async (username, password) => {

    try {

      const response = await axios.post(`${import.meta.env.VITE_BASE_API_URL}/auth/login`,

        { UserName: username, Password: password }

      );

      logDevResponse('login', response?.data);

      if (response?.data?.Token) {

        localStorage.setItem('token', response?.data?.Token);

        localStorage.setItem('displayName', response?.data?.DisplayName);

        localStorage.setItem('expiration', response?.data?.Expiration);

      }

      return response?.data;

    } catch (error) {

      throw error;

    }

  },



  logout: () => {

    localStorage.removeItem('token');

  },



  getCurrentUser: async () => {

    const token = localStorage.getItem('token');

    const name = localStorage.getItem('displayName');

    if (token) {

      try {

        const response = await api.get('/Person/GetMyRoles');

        logDevResponse('getCurrentUser/GetMyRoles', response?.data);

        const roles = response?.data || [];

        return {

          isAuthenticated: true,

          token,

          name,

          role: roles[0] || null,

          roles: roles,

        };

      } catch (error) {

        console.error('Error fetching roles:', error);

        return { isAuthenticated: false };

      }

    }

    return { isAuthenticated: false };

  },



  forgotPassword: async (email) => {

    try {

      const response = await axios.post(`${import.meta.env.VITE_BASE_API_URL}/auth/ForgotPassword`, { EmailAddress

        : email });

      logDevResponse('forgotPassword', response?.data);

      return response?.data;

    } catch (error) {

      throw error;

    }

  }





};



export default authService;  {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("login");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(52)
                .HasColumnName("password");
            entity.Property(e => e.UserName)
                .HasMaxLength(52)
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PRIMARY");

            entity.ToTable("students");

            entity.Property(e => e.Sid)
                .HasColumnType("int(11)")
                .HasColumnName("sid");
            entity.Property(e => e.Address)
                .HasMaxLength(52)
                .HasColumnName("address");
            entity.Property(e => e.Email)
                .HasMaxLength(152)
                .HasColumnName("email");
            entity.Property(e => e.Gender)
                .HasColumnType("enum('male','female')")
                .HasColumnName("gender");
            entity.Property(e => e.Name)
                .HasMaxLength(52)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasColumnType("bigint(52)")
                .HasColumnName("phone");
            entity.Property(e => e.RollNo)
                .HasColumnType("int(52)")
                .HasColumnName("roll_no");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
