using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonBaseType.Model;
using Microsoft.EntityFrameworkCore;


    public interface IBaseTypeRepository
    {

        Task<TblCommonBaseType> ws_loadBaseTypeById(int id);
        //Task<TblCommonBaseType> ws_loadBaseTypeByIdIncloud(int id);
        IEnumerable<TblCommonBaseType> ws_loadBaseType();
        Task<TblCommonBaseType> ws_loadBaseTypeByTitle(string value);
        Task<TblCommonBaseType> ws_CreateBaseType(TblCommonBaseType tblcommandBasetype);
        Task<TblCommonBaseType> ws_UpdateBaseType(TblCommonBaseType tblcommandBasetype);
        Task<TblCommonBaseType> ws_DeleteBaseType(int id);
        Task<bool> IsExists(int id);
        Task<bool> IsExistscode(string value);

    }

