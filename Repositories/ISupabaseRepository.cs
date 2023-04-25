﻿using HealthApplication.Models;

namespace HealthApplication.Repositories
{
    public interface ISupabaseRepository
    {
        public Task<bool> UpdateUser(UserProfile user);
        public Task AddRoutineExercise(RoutineExerciseModel re);

        public Task AddUserRoutine(UserRoutineModel ur);
        public Task<UserProfile> GetUser(Guid id);

        public Task<IEnumerable<ExerciseModel>> GetExercises();
    }
}
