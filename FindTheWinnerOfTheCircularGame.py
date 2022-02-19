class Solution:
    def __init__(self):
        self.y=0
    def findTheWinner(self, n: int, k: int) -> int:
        answer =[]
        for i in range(1,n+1):
            answer.append(i)
        self.winner(answer,k,0)
        del answer
        return self.y
    def winner(self,x,k,start):
        if len(x) == 1 :
            self.y = x[0]
        else:
            x.pop((start+k-1)%len(x))
            self.winner(x,k,(start+k-1)%(len(x)+1))
