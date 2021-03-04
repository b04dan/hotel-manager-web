export class Schedule {
  constructor(public id: number,
              public monday?: number,
              public tuesday?: number,
              public wednesday?: number,
              public thursday?: number,
              public friday?: number,
              public saturday?: number,
              public sunday?: number,
  ) {
  }
}
