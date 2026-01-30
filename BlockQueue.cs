

namespace Tetris
{
    public class BlockQueue
    {
        private readonly Block[] block = new Block[]
        {
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock()
        };
        private readonly Random random = new Random();
        public Block NextBlock { get; private set; }
        public BlockQueue()
        {
            NextBlock = RandomBlock();
        }
        private Block RandomBlock()
        {
            return block[random.Next(block.Length)];
        }
        public Block GetANdUpdate()
        {
            Block block = NextBlock;
            do
            {
                NextBlock = RandomBlock();
            }
            while (block.Id == NextBlock.Id);
            return block;
        }
    }
}
