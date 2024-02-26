
using DIKUArcade.Entities;
using DIKUArcade.Graphics;
namespace Galaga{

    public class Player {
        private Entity entity;
        private DynamicShape shape;
        private float moveLeft =0.0f;
       
        private float moveRight= 0.0f;
        private const float MOVEMENT_SPEED = 0.1f;

        public DynamicShape Shape{
            get {
                return shape;
            }
        }
        

        public Player(DynamicShape shape, IBaseImage image) {
            entity = new Entity(shape, image);
            this.shape = shape;
        }

        public void Render() {
            entity.RenderEntity();
        }

        public void Move() {
            if (((this.GetPosition() + this.moveLeft) > 0) &&
            ((this.GetPosition() + this.shape.Extent.X + this.moveRight) < 1)) {
            this.shape.Move();
            }
        }

        public void SetMoveLeft(bool val) {
            if (val){
                this.moveLeft = -MOVEMENT_SPEED;

            }else{
                this.moveLeft = 0;
            }
            this.UpdateDirection();
        }

        public void SetMoveRight(bool val) {
            if (val){
                this.moveRight = MOVEMENT_SPEED;

            }else{
                this.moveRight= 0;
            }
            this.UpdateDirection();
        }

        private void UpdateDirection(){
            Shape.Direction.X += this.moveLeft + this.moveRight;
        }

        public float GetPosition(){
            return this.shape.Position.X;
        }


    }

}

