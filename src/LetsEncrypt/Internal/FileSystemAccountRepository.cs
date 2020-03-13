// Copyright (c) Nate McMaster.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using McMaster.AspNetCore.LetsEncrypt.Accounts;

namespace McMaster.AspNetCore.LetsEncrypt
{
    internal class FileSystemAccountRepository : IAccountRepository
    {
        private readonly DirectoryInfo _accountDir;

        public FileSystemAccountRepository(DirectoryInfo rootDirectory)
        {
            _accountDir = rootDirectory.CreateSubdirectory("accounts");
        }

        public Task<AccountModel?> GetAccountAsync(CancellationToken cancellationToken)
        {
            
        }

        public Task SaveAccountAsync(AccountModel account, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
