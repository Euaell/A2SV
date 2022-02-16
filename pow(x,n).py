class Solution:
    def myPow(self, x: float, n: int) -> float:
        if n > 100000:
            return (x**100000)*self.myPow(x,n-100000)
        elif n > 0:
            return x*self.myPow(x,n-1)
        elif n < -100000:
            return ((1/x)**100000)*self.myPow(x,n+100000)
        elif n < 0:
            return (1/x)*self.myPow(x,n+1)
        else :
            return 1
