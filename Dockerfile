FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS build
WORKDIR /src

COPY TddPalindrome.Domain/ TddPalindrome.Domain/
COPY TddPalindrome.Tests/ TddPalindrome.Tests/
COPY impacta-tdd-palindrome.sln .
ENTRYPOINT ["dotnet", "test"]