internal class EmailInputError : UserError
{
    public override string UEMessage() => Language.EmailInputErrorText;
}