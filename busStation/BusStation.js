/*
	Create a transport station (TS) (for busses)
	The TS should have busses which are part of the Bus class.
	Each bus should have different number (line number), color, number of passengers, and ticket price.
	Passengers should be part of Passenger class.
	Each bus should have different status e.g: moving, broken, status of passangers at the moment, pick up passangers, passangers leaving etc
	
    Put them in array and print them on console log with status
    
  struktura----  buses=[
        {
            line:5,
            color:red,
            ticket: 30 mkd,
            status: 'moving',
            PassengersOnBus,--currently on bus
            capacity -- total capacity
            availableSeats -- currently on Bus station
            currently_onBoard
            Available_after

        }
    ]
*/


class Bus {
    constructor(line, buscolor, ticket, status, capacity) {
        this.line = line;
        this.buscolor = buscolor;
        this.ticket = ticket;
        this.status = status;
        this.capacity = capacity;
        this.availableSeats = 0;
        this.occupied = 0;
        this.passengers = [];
        

    }

    Passengers_LeaveAndBoard_OnStation() {

        for (let passenger of passengers) {
            if (passenger.bus.line == this.line) {
                this.passengers.push(passenger);

            }
        }
    }


    availability() {
        for (let passenger of this.passengers) {
            if (passenger.passengerStatus == 'boarding' && this.status != 'broken') {
                this.occupied++;
            } else if (passenger.passengerStatus == 'leaving' && this.status != 'broken') {
                this.availableSeats++;
            }
        }
    }


    availabilityAfterLeaving() {
        this.seats_Left = this.capacity - this.occupied;
    }
}

class Passenger {
    constructor(name, passengerStatus, bus, onStation) {
        this.name = name;
        this.passengerStatus = passengerStatus;
        this.bus = bus;
        this.station=onStation;
    }
}


let Line1 = new Bus(23, 'red', '30 mkd', 'moving', 10, 50, 15);
let Line2 = new Bus(45, 'red', '30 mkd', 'broken', 0, 50, 50);
let Line3 = new Bus(5, 'red', '30 mkd', 'moving', 24, 50, 26);
let Line4 = new Bus(3, 'red', '30 mkd', 'moving', 30, 50, 20);
let Line5 = new Bus(50, 'red', '30 mkd', 'moving', 15, 50, 35);

let Vladimir = new Passenger('Vlaidmir', 'boarding', Line1);
let Dejan = new Passenger('Dejan', 'boarding', Line4);
let Mia = new Passenger('Mia', 'boarding', Line5);
let Joe = new Passenger('Joe', 'leaving', Line3);
let Steffany = new Passenger('Steffany', 'boarding', Line4);
let Ivana = new Passenger('Ivana', 'leaving', Line1);
let Bob = new Passenger('Bob', 'boarding', Line3);
let Ivona = new Passenger('Ivona', 'leaving', Line5);
let Marina = new Passenger('Marina', 'boarding', Line4);

let Buses = [];
let passengers = [];
passengers.push(Vladimir, Dejan, Mia, Joe, Steffany, Ivana, Bob, Ivona, Marina);

Buses.push(Line1, Line2, Line3, Line4, Line5);
for (let line of Buses) {
    line.Passengers_LeaveAndBoard_OnStation();
    line.availability();
    line.availabilityAfterLeaving();
}

console.log(Buses);