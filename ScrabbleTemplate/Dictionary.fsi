﻿// Insert your Dictionary.fsi file here. All modules must be internal

module internal Dictionary

    type Dict
    val empty : unit -> Dict
    val insert : string -> Dict -> Dict
    val lookup : string -> Dict -> bool
    val step : char -> Dict -> (bool * Dict) option