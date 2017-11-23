﻿namespace ES.DAL.Interfaces
{
    public interface IHerramientas
    {
        #region Encryption

        // Encrypt()
        string Encrypt(string data);

        // Decrypt()
        string Decrypt(string data);

        #endregion Encryption

        // Capitalize()
        string Capitalize(string text);
    }
}