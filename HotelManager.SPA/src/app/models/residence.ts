export class Residence {
  constructor(public id: number,
              public hotelRoomId: number,
              public clientId: number,
              public clientSNP: string,
              public checkInDate: Date,
              public checkOutDate: Date) {
  }
}
