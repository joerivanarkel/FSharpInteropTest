namespace TestLibrary

type Employee ()= class

        let mutable id = 0  
        let mutable name = " "  
        let mutable salary = 0.0  
       
        member x.Insert(i,n,s) =   
                id <- i  
                name <-n  
                salary<-s   
        member x.Show =   
                printfn "%d %s %0.2f" id name salary  
end
