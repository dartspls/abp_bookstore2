using Volo.Abp;

namespace Acme.BookStore.Authors
{
    internal class AuthorAlreadyExistsException : BusinessException
    {
        public AuthorAlreadyExistsException(string name)
            : base(BookStoreDomainErrorCodes.AuthorAlreadyExists)
        {
            WithData("name", name);

        }
    }
}
