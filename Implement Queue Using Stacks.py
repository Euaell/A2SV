class MyQueue:

    def __init__(self):
        self.obj=[]
        

    def push(self, x: int) -> None:
        self.obj.append(x)

    def pop(self) -> int:
        if len(self.obj)>0:
            return self.obj.pop(0)            

    def peek(self) -> int:
        if len(self.obj)>0:
            return self.obj[0]

    def empty(self) -> bool:
        if len(self.obj)>0:
            return False
        else :
            return True
