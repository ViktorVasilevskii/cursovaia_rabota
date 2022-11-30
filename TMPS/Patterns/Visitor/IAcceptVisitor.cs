namespace Patterns.Visitor
{
    public interface IAcceptVisitor
    {
        void Accept(IVisitor visitor);
    }
}