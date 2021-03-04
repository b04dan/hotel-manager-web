export class Worker {
  constructor(public id: number,
              public surname: string,
              public name: string,
              public patronymic: string,
              public passportNumber: string,
              public email: string,
              public phoneNumber: string,
              public weeklyScheduleId: number,
              public workDaysCount: number,
              public working: boolean,
              public workdaySalary: number) {
  }
}
