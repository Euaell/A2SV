class Solution:
    def findOriginalArray(self, changed: List[int]) -> List[int]:
        y = [0]*(max(changed)+1)
        orignal =[]
        if(not len(changed)%2 == 0):
           
            return []
        for var in range(0,len(changed)):
            y[changed[var]] = y[changed[var]]+1
        if (y[0]%2==0):
            n=y[0]//2
            for k in range(0,n):
                orignal.append(0)
                
        else :
            return []
        for i in range(1,len(y)):
            if  y[i]== 0 :
                continue 
            elif 2*i >= len(y):
                # print(hello1)
                return []
            else :
                while (y[i]>0):
                    y[i]=y[i]-1
                    y[2*i]=y[2*i]-1
                    if(y[2*i]<0):
                        return []
                    else :
                        orignal.append(i)
        return orignal
