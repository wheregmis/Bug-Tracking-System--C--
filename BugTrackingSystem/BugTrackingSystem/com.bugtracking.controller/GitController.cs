using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem.com.bugtracking.controller
{
    class GitController
    {
        private readonly string _repoSource;
        private readonly UsernamePasswordCredentials _credentials;
        private readonly DirectoryInfo _localFolder;
        private string localfolder;

        /// <summary>
        /// Initializes a new instance of the <see cref="GitRepositoryManager" /> class.
        /// </summary>
        /// <param name="username">The Git credentials username.</param>
        /// <param name="password">The Git credentials password.</param>
        /// <param name="gitRepoUrl">The Git repo URL.</param>
        /// <param name="localFolder">The full path to local folder.</param>

        public GitController(string username, string password, string gitRepoUrl, string localFolder) {

            this.localfolder = localFolder;
            var folder = new DirectoryInfo(localFolder);

            if (!folder.Exists)
            {
                throw new Exception(string.Format("Source folder '{0}' does not exist.", _localFolder));
            }

            _localFolder = folder;

            _credentials = new UsernamePasswordCredentials
            {
                Username = username,
                Password = password
            };

            _repoSource = gitRepoUrl;
            Console.WriteLine(_repoSource);
            Console.WriteLine("Connected to Local Repository");

        }

        public void Commit(String message)
        {
            using (var repo = new Repository(localfolder))
            {
                // Write content to file system
                var content = message;
                File.WriteAllText(Path.Combine(repo.Info.WorkingDirectory, "fileToCommit.txt"), content);

                // Stage the file
                repo.Stage("fileToCommit.txt");

                // Create the committer's signature and commit
                Signature author = new Signature("Xawbeenregmi", "@xawbeenregmi", DateTime.Now);
                Signature committer = author;

                // Commit to the repository
                Commit commit = repo.Commit(message);

                MessageBox.Show("Committed");
            }
        }



        /// <summary>
        /// Pushes all commits.
        /// </summary>
        /// <param name="remoteName">Name of the remote server.</param>
        /// <param name="branchName">Name of the remote branch.</param>
        /// <exception cref="System.Exception"></exception>
        public void PushCommits()
        {

            using (var repo = new Repository(localfolder))
            {
                Remote remote = repo.Network.Remotes["origin"];
                var options = new PushOptions();
                options.CredentialsProvider = (_url, _user, _cred) =>
                    new UsernamePasswordCredentials { Username = "xawbeenregmi", Password = "n0b0dycanhackme" };
                repo.Network.Push(remote, @"refs/heads/master", options);
                Console.WriteLine("Pushed to github");
                MessageBox.Show("Pushed to github");
            }
        }


    }

  

}
