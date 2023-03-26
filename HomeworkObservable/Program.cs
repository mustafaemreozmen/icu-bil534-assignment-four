TeacherOne teacher = new TeacherOne();

StudentOne student = new StudentOne(teacher);
SupervisorOne supervisor = new SupervisorOne(teacher);

teacher.GiveHomework("A");
teacher.GiveHomework("B");

teacher.RemoveObserver(supervisor);

teacher.GiveHomework("Supervisor's Cannot See Hard Homework");

