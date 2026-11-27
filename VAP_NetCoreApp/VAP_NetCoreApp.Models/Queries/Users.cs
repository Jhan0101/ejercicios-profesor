using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace VAP_NetCoreApp.Models.Queries
{
    public class Users : BaseQuery
    {
        public Users() : base() { }


        public List<VAP_NetCoreApp.Models.User> GetAll()
        {
            var users = new List<VAP_NetCoreApp.Models.User>();
            using (var db = GetConnection())
            {
                users = db.Query<VAP_NetCoreApp.Models.User>(@"SELECT * FROM [User]").ToList();
            }
            return users;
        }

        public User GetByID(int ID)
        {     
            using (var db = GetConnection())
            {
               return db.QueryFirstOrDefault<VAP_NetCoreApp.Models.User>(@"SELECT * FROM [User] WHERE ID = @ID", new { ID });
            }
        }

        public BaseResult CreateUsingSqlCode(User user)
        {
            var sqlParams = new
            {
                user.Email,
                user.Balance,
                user.Age,
                user.RoleID,
            };

            var rowsAffected = 0;
            using (var db = GetConnection())
            {
                rowsAffected = db.Execute(@"INSERT INTO [User] (Email, Balance, Age, RoleID)
                                            VALUES (@email, @balance, @age, @roleid)", user);
            }

            return new BaseResult
            {
                Success = rowsAffected > 0,
                Message = rowsAffected > 0 ? string.Empty : "Por favor contactanos."
            };
        }
        public BaseResult CreateUsingStoredProcedure(User user)
        {
            using (var db = GetConnection())
            {
                return db.QueryFirstOrDefault<BaseResult>(@"User_AddUser", new
                {
                    user.Email,
                    user.RoleID,
                    user.Balance,
                    user.Age
                }, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public BaseResult Update(User user)
        {
            var sqlParams = new
            {
                user.Email,
                user.Balance,
                user.Age,
                user.RoleID,
            };

            var rowsAffected = 0;
            using (var db = GetConnection())
            {
                rowsAffected = db.Execute(@"UPDATE [User] 
                                            SET Email = @email
                                                , RoleID = @roleID
                                                , Age = @age
                                                , isActive = @isActive
                                                , Balance = @balance
                                                WHERE ID = @ID", user);
            }

            return new BaseResult
            {
                Success = rowsAffected > 0,
                Message = rowsAffected > 0 ? string.Empty : "Por favor contactanos."
            };
        }
    }
}
