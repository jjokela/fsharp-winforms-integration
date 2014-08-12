namespace SortingAlgorithms

module Utils = 

    let swap x y (arr : 'a []) = 
        let temp = arr.[x]
        arr.[x] <- arr.[y]
        arr.[y] <- temp

// Bubble Sort

// Worst case performance: O(n^2)
// Average case performance: O(n^2)
// Best case performance: O(n)

// Best for: small and nearly sorted data sets

// Pseudocode:
// On each pass
// compare each array item to its right neighbor
// if the neighbor is smaller, then swap right and left
// repeat for remaining items
// do until no swaps are done
module BubbleSort = 

    let Sort arr = 
        let rec loop (arr : 'a []) =
            let mutable swapCount = 0
            // no need to check last item on array
            for i = 0 to arr.Length - 2 do
                if arr.[i] > arr.[i+1] then
                    Utils.swap i (i+1) arr
                    swapCount <- swapCount + 1
            if swapCount > 0 
                then loop arr 
                    else arr // return sorted array
        loop arr

// Insertion Sort

// Worst case performance: O(n^2)
// Average case performance: O(n^2)
// Best case performance: O(n)

// Best for: small and nearly sorted data sets

// Pseudocode:
// take one element at a time
// compare it to the elements of right (everything on right-side is sorted)
// if element is smaller than right, move to next
// move while element is larger than left, smaller than right
module InsertionSort = 

    let Sort (arr : 'a []) = 
        for i = 1 to arr.Length - 1 do
            let mutable j = i
            while j >= 1 && arr.[j-1] > arr.[j] do
                Utils.swap j (j-1) arr
                j <- (j-1)
        arr // return value

// Selection Sort

// Worst case performance: O(n^2)
// Average case performance: O(n^2)
// Best case performance: O(n^2)

// Best for: small and nearly sorted data sets

// Pseudocode:
// go through all of the elements
// find smallest element
// put it right after the sorted elements
// continue until all elements are handled
module SelectionSort = 

    let rec Sort (arr : 'a []) =
        
        let split (arr : _ array) =
            let n = arr.Length
            arr.[0..n/2-1], arr.[n/2..n-1]
 
        let rec merge (l : 'a array) (r : 'a array) =
            let n = l.Length + r.Length
            let res = Array.zeroCreate<'a> n
            let mutable i, j = 0, 0
            for k = 0 to n-1 do
                if i >= l.Length   then res.[k] <- r.[j]; j <- j + 1
                elif j >= r.Length then res.[k] <- l.[i]; i <- i + 1
                elif l.[i] < r.[j] then res.[k] <- l.[i]; i <- i + 1
                else res.[k] <- r.[j]; j <- j + 1
 
            res
 
        match arr with 
        | [||] | [| _ |] -> arr
        | _ -> let (x, y) = split arr
               merge (Sort x) (Sort y)

// Merge Sort
// Divide & Conquer algorithm

// Worst case performance: O(n log n)
// Average case performance: O(n log n)
// Best case performance: O(n log n)

// Best for: large datasets

// Pseudocode:
// split array recursively in half
// when array is in groups of one, start rebuilding them in sorted order
// e.g. 654321 -> 654, 321 -> 65, 4, 32, 1 -> 6, 5, 4, 3, 2, 1
// 56, 34, 12 -> 3456, 12 -> 123456 
module MergeSort = 

    let Sort (arr: 'a []) = 
        let rec loop n (arr : 'a []) = 
            if n >= arr.Length - 1 then arr // return
            else
                let mutable x, mini = arr.[n], n
                for i = n+1 to arr.Length - 1 do
                    if arr.[i] < x then
                        x <- arr.[i]
                        mini <- i
                if n <> mini then Utils.swap n (mini) arr

                loop (n+1) arr

        loop 0 arr

// Quick Sort
// Divide & Conquer algorithm

// Worst case performance: O(n^2)
// Average case performance: O(n log n)
// Best case performance: O(n log n)

// Best for: large datasets

// Pseudocode:
// pick a pivot value and partition the array
// put smaller values to left and larger values to right -> pivot point is now sorted
// perform same operation to left and right partitions
// repeat until sorted

module QuickSort = 

    let inline partition(arr : 'a [], left, right, pivotIndex) = 
        let pivot = arr.[pivotIndex]    
        Utils.swap pivotIndex right arr // move pivot to the end
 
        let mutable storeIndex = left
        for i = left to right - 1 do // left <= i < right
            if arr.[i] <= pivot then 
                Utils.swap i storeIndex arr
                storeIndex <- storeIndex + 1
        Utils.swap storeIndex right arr // move pivot to its final place
        storeIndex

    let inline Sort (arr : 'a []) =
        let rec loop (arr : 'a [], left, right) =
            // if the array has 2 or more items
            if left < right then
                // use the middle element, and sort the elements according to the value of the pivot
                // and return the new idx of the pivot
                let pivotIdx = (left + right) / 2
                let pivotNewIdx = partition(arr, left, right, pivotIdx)
            
                // recursively sort elements either side of the new pivot
                loop(arr, left, pivotNewIdx - 1)
                loop(arr, pivotNewIdx + 1, right)
 
        loop(arr, 0, arr.Length - 1)
        arr