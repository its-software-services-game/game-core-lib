using Its.Games.Core.Commons;

namespace Its.Games.BoardGame2D.Core.BoardGame2D
{
    public abstract class BoardBase : IBoard
    {
        private int maxRow = 0;
        private int maxCol = 0;
        private IMarker[,] board = null;

        protected abstract IMarker[,] CreateBoard();
        protected abstract int GetMaxRow();
        protected abstract int GetMaxCol();

        protected void Put(int x, int y, IMarker mark)
        {
            board[x, y] = mark;
        }

        protected IMarker Get(int x, int y)
        {
            IMarker mark = board[x, y];
            return mark;
        }

        public void Init()
        {
            maxRow = GetMaxRow();
            maxCol = GetMaxCol();
            board = CreateBoard();
        }

        public void Put(ICoordinate coordinate, IMarker mark)
        {
            int row = coordinate.X;
            int col = coordinate.Y;

            board[row, col] = mark;    
        }

        public IMarker Get(ICoordinate coordinate)
        {
            int row = coordinate.X;
            int col = coordinate.Y;

            IMarker marker = board[row, col];
            return marker;
        }
    }
}